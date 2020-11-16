using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagnetsPp365
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            a.RemoveAt(2);

            if (a.Contains("two"))
            {
                a.Add(twopointtwo);
            }

            if (a.Contains("three"))
            {
                a.Add("four");
            }

            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }

            printL(a);

        }

        public static void printL(List<string> a)
        {
            string result = "";

            foreach (string element in a)
            {
                result += "\n" + element;
            }

            MessageBox.Show(result);
        }
    }
}
