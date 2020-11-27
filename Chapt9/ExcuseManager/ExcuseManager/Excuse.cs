using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuseManager
{
    class Excuse
    {
        public string Description { get; internal set; }
        public string Results { get; internal set; }
        public DateTime LastUsed { get; internal set; }
        public string ExcusePath { get; internal set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        private void OpenFile(string path)
        {
            ExcusePath = path;
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }
    }
}
