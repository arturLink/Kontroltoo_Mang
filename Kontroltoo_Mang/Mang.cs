using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Mang
    {
        Character[] players;
        //конструктор
        public Mang(Character[] players)
        {
            this.players = players;
        }
        //перс с самым большим кол-во предметов
        public List<Character> SuurimaEsemeteArvuga()
        {
            List<Character> winners = new List<Character>();
            Character comparable = players[0];
            foreach (Character plr in players)
            {
                int num = comparable.CompareTo(plr);
                if (num < 0)
                {
                    comparable = plr;
                    winners.Clear();
                }
                if (num == 0) winners.Add(plr);
            }
            winners.Add(comparable);
            return winners;
        }
        //перс с самым большим кол-во очков
        public Character suurimaPunktideArvuga()
        {
            int highest = 0;
            Character winner = players[0];
            foreach (Character plr in players)
            {
                int arv = plr.PunktideArv();
                if (arv > highest) { highest = arv; winner = plr; }
            }
            return winner;
        }
    }
}
