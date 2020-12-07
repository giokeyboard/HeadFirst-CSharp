using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HexDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Card testCard = new Card(Suits.Hearts, Values.Queen);
            using (Stream output = File.Create("testCard.txt"))
            {
                bf.Serialize(output, testCard);
            }

            using (StreamReader reader = new StreamReader(@"C:\Users\gfacchin\Documents\Courses\HeadFirst-C#\Chapt9\HexDumper\HexDumper\bin\Debug\testCard.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\Users\gfacchin\Documents\Courses\HeadFirst-C#\Chapt9\HexDumper\HexDumper\bin\Debug\output.txt"))
            {
                int position = 0;
                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write($"{position:x4}: ");               //hex-formatted (4 digits)
                    position += charactersRead;
                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = $"{(byte)buffer[i]:x2}";   //hex-formatted (2 digits)
                            writer.Write(hex + " ");
                        }
                        else writer.Write("   ");

                        if (i == 7) writer.Write("-- ");
                        if (buffer[i] < 32 || buffer[i] > 250) buffer[i] = '.';
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
