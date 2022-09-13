using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    //класс отвечающий персонажей
    internal class Character : IEntity, IComparable<Character>
    {
        string nimi;
        List<Ese> esed;

        //конструктор для создания персонажей
        public Character(string nimi, List<Ese> esed)
        {
            this.nimi = nimi;
            this.esed = esed;
        }

        //метод для добавления предметов персонажам
        public void lisaEse(Ese item)
        {
            esed.Add(item);
        }

        //метод для вычисления количества очков за все предметы
        public int PunktideArv()
        {
            int sum = 0;
            foreach (Ese x in esed) 
            { 
                sum += x.PunktideArv(); 
            }
            return sum;
        }
        
        //метод выводящий информацию о персонаже, его предметах и их количество очков от этих предметов
        public string Info()
        {
            return $"{this.nimi}. This character has {esed.Count} items and those items give {PunktideArv()} points";
        }

        //выводит предметы и информацию о предметах
        public void väljastaEsemed()
        {
            foreach (Ese x in esed)
            {
                Console.WriteLine("{0}\n", Info());
            }
        }

        //возвращает в порядковой последовательности
        public int CompareTo(Character? other)
        {
            if (other == null) return 1;
            return this.esed.Count() - other.esed.Count();
        }

    }
}
