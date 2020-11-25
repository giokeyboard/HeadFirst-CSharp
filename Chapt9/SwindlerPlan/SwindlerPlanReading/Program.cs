using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwindlerPlanReading
{
    class Program
    {
        static void Main(string[] args)
        {
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //StreamReader reader = new StreamReader(folder + @"\secret_plan.txt");
            //StreamWriter writer = new StreamWriter(folder + @"\emailToCaptainAmazing.txt");
            StreamReader reader = new StreamReader(@"C:\Users\gfacchin\Documents\secret_plan2.txt");
            StreamWriter writer = new StreamWriter(@"C:\Users\gfacchin\Documents\emailToCaptainAmazing.txt");
            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We’ve discovered the Swindler’s plan:");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();
        }
    }
}
