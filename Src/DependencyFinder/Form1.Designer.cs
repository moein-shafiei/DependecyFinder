namespace DependencyFinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.FindDependeciesBtn = new System.Windows.Forms.Button();
            this.DependeciesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(12, 12);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(635, 20);
            this.FolderPathTextBox.TabIndex = 0;
            this.FolderPathTextBox.Leave += new System.EventHandler(this.FolderPathTextBox_Leave);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(653, 12);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // FindDependeciesBtn
            // 
            this.FindDependeciesBtn.Location = new System.Drawing.Point(734, 12);
            this.FindDependeciesBtn.Name = "FindDependeciesBtn";
            this.FindDependeciesBtn.Size = new System.Drawing.Size(136, 23);
            this.FindDependeciesBtn.TabIndex = 2;
            this.FindDependeciesBtn.Text = "Find Dll Dependecies";
            this.FindDependeciesBtn.UseVisualStyleBackColor = true;
            this.FindDependeciesBtn.Click += new System.EventHandler(this.FindDependeciesBtn_Click);
            // 
            // DependeciesListBox
            // 
            this.DependeciesListBox.FormattingEnabled = true;
            this.DependeciesListBox.Location = new System.Drawing.Point(12, 38);
            this.DependeciesListBox.Name = "DependeciesListBox";
            this.DependeciesListBox.Size = new System.Drawing.Size(635, 394);
            this.DependeciesListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.DependeciesListBox);
            this.Controls.Add(this.FindDependeciesBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.FolderPathTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button FindDependeciesBtn;
        private System.Windows.Forms.ListBox DependeciesListBox;
    }
}

