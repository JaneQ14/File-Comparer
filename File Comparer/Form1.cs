using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace File_Comparer
{
    public partial class File_Comparer : Form
    {
        public File_Comparer()
        {
            InitializeComponent();
        }

        private void File_Comparer_Load(object sender, EventArgs e)
        {
            textBox3.Text = Environment.CurrentDirectory;
        }

        private bool FileEquals(string path1, string path2)
        {
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);

            if (f1.Length != f2.Length)
                return false;

            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);

            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                
                return true;
            }

            return false;
        }

        Dictionary<FileInfo, List<FileInfo>> container = new Dictionary<FileInfo, List<FileInfo>>();
        List<DirectoryInfo> folders = new List<DirectoryInfo>();
        List<FileInfo> files = new List<FileInfo>();
        List<FileInfo> existsList = new List<FileInfo>();

        private void FolderEquals(string fpath)
        {           
            DateTime start = DateTime.Now;
            results.Text = "loading...";

            DirectoryInfo dir = new DirectoryInfo(fpath); //folder dir (main)
            FullDirList(dir); //we got all files

            for(int i = 0; i < files.Count; i++)
            {
                //adding files and new list to each
                container.Add(files[i], new List<FileInfo>());
            }

            int errors = 0;

            for (int j = 0; j < container.Keys.Count; j++)
            {
                if (existsList.Contains(files[j]))
                {
                    continue;
                }

                for (int k = 0; k < container.Keys.Count; k++)
                {    
                    if (container.ElementAt(j).Key == container.ElementAt(k).Key)
                    {
                        continue;
                    }

                    bool match = false;
                    //comparuj j plik z każdym k plikiem
                    try
                    {
                        match = FileEquals(container.ElementAt(j).Key.FullName, container.ElementAt(k).Key.FullName);
                    }
                    catch { errors++; continue; }
                    //Console.WriteLine(container.ElementAt(j).Key.FullName + "==" + container.ElementAt(k).Key.FullName);
                    
                    if(match)
                    {
                        container[files[j]].Add(container.ElementAt(k).Key);
                        existsList.Add(container.ElementAt(k).Key);
                    }

                    results.Text = $"{j}/{container.Keys.Count}";
                }

                if(!existsList.Contains(container.ElementAt(j).Key))
                    existsList.Add(container.ElementAt(j).Key);
            }
            
            string temp = string.Empty;
            foreach (KeyValuePair<FileInfo, List<FileInfo>> file in container)
            {
                //Console.WriteLine("Key: {0}, Value: {1}", file.Key, file.Value);
                if(file.Value.Count == 0)
                {
                    continue;
                }

                temp += $"\n{file.Key.Length}B\n{file.Key.Name}\n";
                for (int l = 0; l < file.Value.Count; l++)
                {
                    temp += $"{file.Value[l].Name}\n";
                }
            }

            if (string.IsNullOrEmpty(temp))
            {
                temp = "\nNo duplicates found.";
            }
            //MessageBox.Show($"We got {container.Count} files.\n" + temp, $"Attention!");
            results.Text = string.Empty;
            results.Text = $"{container.Count} files found in\n{dir.FullName}\nErrors: {errors}\n" + temp;
            results.Text = results.Text.Replace("\n", Environment.NewLine);

            container = new Dictionary<FileInfo, List<FileInfo>>();
            folders = new List<DirectoryInfo>();
            files = new List<FileInfo>();

            TimeSpan Diff_dates = DateTime.Now.Subtract(start);
            MessageBox.Show($"done.\n{Diff_dates.TotalSeconds}s", "Attention!");
        }

        void FullDirList(DirectoryInfo dir)
        {
            try
            {
                foreach (FileInfo f in dir.GetFiles("*"))
                {
                    files.Add(f);
                }
            }
            catch
            {
                MessageBox.Show(dir.FullName + "\ncould not be accessed.", "error - no permission");
                return;
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                folders.Add(d);
                FullDirList(d);
            }
        }

        private void ChooseFile(TextBox textBox)
        {
            ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                textBox.Text = ofd.FileName.ToString();
            }
        }

        private void ChooseFolder(TextBox textBox)
        {
            fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                textBox.Text = fbd.SelectedPath.ToString();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (File.Exists(textBox.Text))
            {
                textBox.ForeColor = Color.Green;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }

            if (File.Exists(textBox1.Text) && File.Exists(textBox2.Text))
            {
                compare_button.Enabled = true;
            }
            else
            {
                compare_button.Enabled = false;
            }        
        }

        private void browse_button1_Click(object sender, EventArgs e)
        {
            ChooseFile(textBox1);
        }

        private void browse_button2_Click(object sender, EventArgs e)
        {
            ChooseFile(textBox2);
        }

        private void compare_button_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("you must provide the paths to the files.", "Error");
                return;
            }

            bool match = false;
            try
            {
                if (textBox1.Text != textBox2.Text)
                {
                    match = FileEquals(textBox1.Text, textBox2.Text);
                }
                else
                {
                    match = true;
                }
            }
            catch { }

            string temp;
            FileInfo file1 = new FileInfo(textBox1.Text);
            FileInfo file2 = new FileInfo(textBox2.Text);
            if(match)
            {
                temp = $"{file1.Name}\nequals\n{file2.Name}";
            }
            else
            {
                temp = $"{file1.Name}\ndoes not equal\n{file2.Name}";
            }

            TimeSpan Diff_dates = DateTime.Now.Subtract(start);
            MessageBox.Show($"{temp}\n\n{Diff_dates.TotalSeconds}s", "Attention!");
        }

        private void textbox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            var textBox = (TextBox)sender;
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                textBox.Text = files.First(); //select the first one  
        }

        private void dupliactes_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("you must provide the paths to the files.", "Error");
                return;
            }

            FolderEquals(textBox3.Text);
        }

        private void browse3_button(object sender, EventArgs e)
        {
            ChooseFolder(textBox3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (Directory.Exists(textBox.Text))
            {
                textBox.ForeColor = Color.Green;
                dupliactes_button.Enabled = true;
            }
            else
            {
                textBox.ForeColor = Color.Red;
                dupliactes_button.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseFile(hash_textbox);
        }

        private void hash_textbox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (File.Exists(textBox.Text))
            {
                textBox.ForeColor = Color.Green;
                hash_button.Enabled = true;
            }
            else
            {
                textBox.ForeColor = Color.Red;
                hash_button.Enabled = false;
            }
        }

        private void hash_button_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            outhash_textbox.Text = string.Empty;
            string fpath = hash_textbox.Text;
            outhash_textbox.Text = 
                $"SHA1\n{ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA1, fpath)}\n\n" +
                $"SHA256\n{ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, fpath)}\n\n" +
                $"SHA384\n{ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA384, fpath)}\n\n" +
                $"SHA512\n{ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA512, fpath)}\n\n" + 
                $"MD5\n{ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, fpath)}";

            outhash_textbox.Text = outhash_textbox.Text.Replace("\n", Environment.NewLine);
            TimeSpan Diff_dates = DateTime.Now.Subtract(start);
            MessageBox.Show($"done.\n{Diff_dates.TotalSeconds}s", "Attention!");
        }
    }
}

public static class ChecksumUtil
{
    public static string GetChecksum(HashingAlgoTypes hashingAlgoType, string filename)
    {
        using (var hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
        {
            using (var stream = System.IO.File.OpenRead(filename))
            {
                var hash = hasher.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }
}
public enum HashingAlgoTypes
{
    MD5,
    SHA1,
    SHA256,
    SHA384,
    SHA512
}