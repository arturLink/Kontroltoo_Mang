using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    //класс отвечающий за предметы
    internal class Ese : IUksus
    {
        int punktideArv;
        string info;

        //конструктор создающий предметы
        public Ese(string info, int punktideArv)
        {
            this.punktideArv = punktideArv;
            this.info = info;
        }

        public int PunktideArv() { return punktideArv; }
        public string Info() { return info; }
    }
}
