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

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = "";
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = description.Text + ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse Written!");

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FileName = description.Text + ".txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }

        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                if (MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return false;
                }

            }
            return true;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
    }
}
