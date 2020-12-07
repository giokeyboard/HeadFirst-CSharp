using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInnerWorkings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialize two Card objects to different files
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output1 = File.Create("three-c.dat"))
            using (Stream output2 = File.Create("six-h.dat"))
            {
                bf.Serialize(output1, new Card(Suits.Clubs, Values.Three));
                bf.Serialize(output2, new Card(Suits.Hearts, Values.Six));
            }

            //Compare the two binary files
            byte[] file1 = File.ReadAllBytes("three-c.dat");
            byte[] file2 = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < file1.Length; i++)
            {
                if (file1[i] != file2[i]) Console.WriteLine($"Byte #{i}: {file1[i]} vs {file2[i]}");
            }

            //Manually create a new file that contains the King of Spades
            file1[327] = (byte)Suits.Spades;
            file1[388] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", file1);

            //Deserialize the card from file and see if it’s the King of Spades
            Card kingSpades;
            using (Stream input = File.OpenRead("king-s.dat"))
            {
                kingSpades = (Card)bf.Deserialize(input);
            }
            Console.WriteLine($"\r\nThe card just read from file is:\r\n{kingSpades}");
        }
    }
}
