using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class Form1 : Form
    {
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card((Suits)random.Next(0, 4), (Values)random.Next(1, 14));
            textBox1.Text = card.Name;
        }
    }
}
