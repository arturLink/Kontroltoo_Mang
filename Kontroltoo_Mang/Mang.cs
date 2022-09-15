using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Mang
    {
        Tegelane[] players;
        //конструктор
        public Mang(Tegelane[] players)
        {
            this.players = players;
        }
        //перс с самым большим кол-во предметов
        public List<Tegelane> SuurimaEsemeteArvuga()
        {
            List<Tegelane> winners = new List<Tegelane>();
            Tegelane comparable = players[0];
            foreach (Tegelane plr in players)
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
        public Tegelane suurimaPunktideArvuga()
        {
            int highest = 0;
            Tegelane winner = players[0];
            foreach (Tegelane plr in players)
            {
                int arv = plr.PunktideArv();
                if (arv > highest) 
                { 
                    highest = arv; 
                    winner = plr; 
                }
            }
            return winner;
        }
    }
}
