
namespace File_Comparer
{
    partial class File_Comparer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Comparer));
            this.browse1_button = new System.Windows.Forms.Button();
            this.browse2_button = new System.Windows.Forms.Button();
            this.compare_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.page0 = new System.Windows.Forms.TabPage();
            this.max_label = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.dupliactes_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outhash_textbox = new System.Windows.Forms.TextBox();
            this.hash_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.hash_textbox = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.page0.SuspendLayout();
            this.page1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse1_button
            // 
            this.browse1_button.Location = new System.Drawing.Point(328, 42);
            this.browse1_button.Name = "browse1_button";
            this.browse1_button.Size = new System.Drawing.Size(75, 23);
            this.browse1_button.TabIndex = 0;
            this.browse1_button.Text = "Browse...";
            this.browse1_button.UseVisualStyleBackColor = true;
            this.browse1_button.Click += new System.EventHandler(this.browse_button1_Click);
            // 
            // browse2_button
            // 
            this.browse2_button.Location = new System.Drawing.Point(328, 127);
            this.browse2_button.Name = "browse2_button";
            this.browse2_button.Size = new System.Drawing.Size(75, 23);
            this.browse2_button.TabIndex = 1;
            this.browse2_button.Text = "Browse...";
            this.browse2_button.UseVisualStyleBackColor = true;
            this.browse2_button.Click += new System.EventHandler(this.browse_button2_Click);
            // 
            // compare_button
            // 
            this.compare_button.Enabled = false;
            this.compare_button.Location = new System.Drawing.Point(167, 178);
            this.compare_button.Name = "compare_button";
            this.compare_button.Size = new System.Drawing.Size(75, 25);
            this.compare_button.TabIndex = 2;
            this.compare_button.Text = "Compare";
            this.compare_button.UseVisualStyleBackColor = true;
            this.compare_button.Click += new System.EventHandler(this.compare_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select file path 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select file path 2:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(6, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox_DragOver);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(6, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox_DragOver);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            this.ofd.RestoreDirectory = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.page0);
            this.tabControl.Controls.Add(this.page1);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 246);
            this.tabControl.TabIndex = 7;
            // 
            // page0
            // 
            this.page0.Controls.Add(this.max_label);
            this.page0.Controls.Add(this.label1);
            this.page0.Controls.Add(this.textBox2);
            this.page0.Controls.Add(this.browse1_button);
            this.page0.Controls.Add(this.textBox1);
            this.page0.Controls.Add(this.browse2_button);
            this.page0.Controls.Add(this.label2);
            this.page0.Controls.Add(this.compare_button);
            this.page0.Location = new System.Drawing.Point(4, 22);
            this.page0.Name = "page0";
            this.page0.Padding = new System.Windows.Forms.Padding(3);
            this.page0.Size = new System.Drawing.Size(430, 220);
            this.page0.TabIndex = 0;
            this.page0.Text = "Files";
            this.page0.UseVisualStyleBackColor = true;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(358, 207);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(69, 13);
            this.max_label.TabIndex = 7;
            this.max_label.Text = "max: 2GB file";
            // 
            // page1
            // 
            this.page1.Controls.Add(this.label4);
            this.page1.Controls.Add(this.results);
            this.page1.Controls.Add(this.dupliactes_button);
            this.page1.Controls.Add(this.button1);
            this.page1.Controls.Add(this.textBox3);
            this.page1.Controls.Add(this.label3);
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(430, 220);
            this.page1.TabIndex = 1;
            this.page1.Text = "Folder";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "max: 2GB file in folder";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(6, 122);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(397, 90);
            this.results.TabIndex = 9;
            // 
            // dupliactes_button
            // 
            this.dupliactes_button.Enabled = false;
            this.dupliactes_button.Location = new System.Drawing.Point(6, 80);
            this.dupliactes_button.Name = "dupliactes_button";
            this.dupliactes_button.Size = new System.Drawing.Size(93, 25);
            this.dupliactes_button.TabIndex = 8;
            this.dupliactes_button.Text = "Find duplicates";
            this.dupliactes_button.UseVisualStyleBackColor = true;
            this.dupliactes_button.Click += new System.EventHandler(this.dupliactes_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browse3_button);
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(6, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox3.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select folder path:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outhash_textbox);
            this.tabPage1.Controls.Add(this.hash_button);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.hash_textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 220);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Checksum";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outhash_textbox
            // 
            this.outhash_textbox.Location = new System.Drawing.Point(6, 122);
            this.outhash_textbox.Multiline = true;
            this.outhash_textbox.Name = "outhash_textbox";
            this.outhash_textbox.ReadOnly = true;
            this.outhash_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outhash_textbox.Size = new System.Drawing.Size(397, 90);
            this.outhash_textbox.TabIndex = 10;
            // 
            // hash_button
            // 
            this.hash_button.Enabled = false;
            this.hash_button.Location = new System.Drawing.Point(328, 71);
            this.hash_button.Name = "hash_button";
            this.hash_button.Size = new System.Drawing.Size(75, 25);
            this.hash_button.TabIndex = 9;
            this.hash_button.Text = "Checksum";
            this.hash_button.UseVisualStyleBackColor = true;
            this.hash_button.Click += new System.EventHandler(this.hash_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select file path:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hash_textbox
            // 
            this.hash_textbox.AllowDrop = true;
            this.hash_textbox.Location = new System.Drawing.Point(6, 42);
            this.hash_textbox.Name = "hash_textbox";
            this.hash_textbox.Size = new System.Drawing.Size(300, 20);
            this.hash_textbox.TabIndex = 6;
            this.hash_textbox.TextChanged += new System.EventHandler(this.hash_textbox_TextChanged);
            this.hash_textbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.hash_textbox.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox_DragOver);
            // 
            // File_Comparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 246);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 285);
            this.MinimumSize = new System.Drawing.Size(450, 285);
            this.Name = "File_Comparer";
            this.Text = "File Comparer";
            this.Load += new System.EventHandler(this.File_Comparer_Load);
            this.tabControl.ResumeLayout(false);
            this.page0.ResumeLayout(false);
            this.page0.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browse1_button;
        private System.Windows.Forms.Button browse2_button;
        private System.Windows.Forms.Button compare_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage page0;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button dupliactes_button;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox hash_textbox;
        private System.Windows.Forms.Button hash_button;
        private System.Windows.Forms.TextBox outhash_textbox;
    }
}

