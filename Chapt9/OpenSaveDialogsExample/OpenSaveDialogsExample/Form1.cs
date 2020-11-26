using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenSaveDialogsExample
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files only (*.txt)|*.txt";
            saveFileDialog1.InitialDirectory = @"C:\Users\gfacchin\Desktop";
            saveFileDialog1.Title = "Giovanni says: please save a file!";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
