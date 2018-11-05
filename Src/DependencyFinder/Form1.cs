using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FolderPathTextBox.Text) && Directory.Exists(FolderPathTextBox.Text))
            {
                folderBrowserDialog1.SelectedPath = FolderPathTextBox.Text;
            }

            folderBrowserDialog1.ShowDialog();
        }

        private void FindDependeciesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                MessageBox.Show("No path is selected");
                return;
            }

            string folderpath = folderBrowserDialog1.SelectedPath;
            var DependecyList = new DependcyFinder().GetDependecyList(folderpath).ToArray();

            DependeciesListBox.Items.AddRange(DependecyList);

            Clipboard.SetText(string.Join("\r\n", DependecyList));
            MessageBox.Show("Result Copied to clipboard");
        }

        private void FolderPathTextBox_Leave(object sender, EventArgs e)
        {
            //D:\Projects\Others\Dot Framework\Projects\IPP.GuesSport\Main\References

            if (!string.IsNullOrEmpty(FolderPathTextBox.Text) && Directory.Exists(FolderPathTextBox.Text))
            {
                folderBrowserDialog1.SelectedPath = FolderPathTextBox.Text;
            }
        }
    }
}
