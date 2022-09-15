using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Peaklass
    {
        public static Random rnd = new Random();

        static Tegelane[] addCharacter(int ChrAmount)
        {
            if (ChrAmount < 4) throw new Exception();
            Tegelane[] players = new Tegelane[ChrAmount];
            for (int i = 0; i < ChrAmount; i++)
            {
                Tegelane player = new Tegelane(getName());
                players[i] = player;
            }

            return liisaEse(players);
        }

        public static void Shuffle<T>(IList<T>list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static string getName()
        {
            string[] names = { "Zora", "Geralt The Witcher", "Rocky Balboa", "Jon Snow", "Ragnar Lothbrok" };
            return names[rnd.Next(names.Length)];
        }

        public static List<Ese> LoeEsemed()
        {
            List<Ese> esed = new List<Ese>();
            using (StreamReader sr=new StreamReader(@"../../../Items.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Ese ese = new Ese(rida[0].ToString(), Int32.Parse(rida[1]));
                    esed.Add(ese);
                }
            }
            return esed;
        }

        static Tegelane[] liisaEse(Tegelane[] characters)
        {
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane x in characters)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    x.liisaEse(itemList[i]);
                }
            }
            return characters;
        }

        static public void Uus_mang(int kogus)
        {
            Tegelane[] chactr = addCharacter(5);
            Mang mang = new Mang(chactr);
            foreach (Tegelane x in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(x.Info());
            }
            Tegelane voitja = mang.suurimaPunktideArvuga();
            Console.WriteLine(voitja.Info());
            Console.WriteLine("Player had these items:");
            voitja.väljastaEsemed();

        }
    }
}
