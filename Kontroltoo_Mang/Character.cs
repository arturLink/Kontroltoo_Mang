using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Character : IEntity, IComparable<Character>
    {
        string nimi;
        List<Ese> esed;

        public Character(string nimi, List<Ese> esed)
        {
            this.nimi = nimi;
            this.esed = esed;
        }

        public void lisaEse(Ese item)
        {
            esed.Add(item);
        }

        public int PunktideArv()
        {
            int sum = 0;
            foreach (Ese x in esed) 
            { 
                sum += x.PunktideArv(); 
            }
            return sum;
        }
        
        public string Info()
        {
            return $"{this.nimi}. This character has {esed.Count} items and those items give {PunktideArv()} points";
        }

        public void väljastaEsemed()
        {
            foreach (Ese x in esed)
            {
                Console.WriteLine("{0}\n", Info());
            }
        }

        public int CompareTo(Character? other)
        {
            if (other == null) return 1;
            return this.esed.Count() - other.esed.Count();
        }

    }
}
