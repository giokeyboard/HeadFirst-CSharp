using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberjacksCafeteria
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakfastLine;

        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food,
            (int)howMany.Value);
            nextInLine.Text = $"{currentLumberjack.Name} has {(int)howMany.Value} flapjacks";
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int count = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add($"{count}. {lumberjack.Name}");
                count++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                nextInLine.Text = $"{breakfastLine.Peek().Name} has {breakfastLine.Peek().FlapjackCount} flapjacks";
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) { MessageBox.Show("Please enter a name!"); return; }
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            breakfastLine.Dequeue().EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }
    }
}
