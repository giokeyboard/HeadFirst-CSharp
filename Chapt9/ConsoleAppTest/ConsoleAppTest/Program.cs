using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Create random Card object
            Card card = GetRandomCard();
            Console.WriteLine($"A random card has just been created: {card}");

            // Serialize the Card object to binary file
            string path = "card.dat";
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.Create(path))
            {
                bf.Serialize(output, card);
            }

            HexDumper(path);

            // De-serialize the object back
            using (Stream input = File.OpenRead(path))
            {
                Card deserializedCard = (Card)bf.Deserialize(input);
                Console.WriteLine($"A card is being read from file: {deserializedCard}");
            }

            //OpenFileDialog openDialog = new OpenFileDialog();
            //openDialog.Filter = ""

            //SaveFileDialog saveDialog = new SaveFileDialog();

        }

        private static Card GetRandomCard()
        {
            Random r = new Random();
            return new Card((Suits)r.Next(0, 4), (Values)r.Next(1, 14));
        }

        private static void HexDumper(string path)
        {
            using (Stream input = File.OpenRead(path))
            {
                int position = 0;
                byte[] buffer = new byte[16];
                while (position < input.Length)
                {
                    int charsRead = input.Read(buffer, 0, 16);
                    if (charsRead > 0)
                    {
                        Console.Write($"{position:x4}: ");
                        position += charsRead;

                        for (int i = 0; i < buffer.Length; i++)
                        {
                            if (i < charsRead)
                            {
                                Console.Write($"{(byte)buffer[i]:x2} ");
                            }
                            else Console.Write("   ");
                            if (i == 7) Console.Write("-- ");
                            if (buffer[i] < 32 || buffer[i] > 250) buffer[i] = (byte)'.';
                        }
                    }
                    Console.WriteLine($"   {Encoding.UTF8.GetString(buffer)}");
                }
            }
        }
    }
}
