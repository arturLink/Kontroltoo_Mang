using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Ese : IEntity
    {
        int punktideArv;
        string info;

        public Ese(string info, int punktideArv)
        {
            this.punktideArv = punktideArv;
            this.info = info;
        }

        public int PunktideArv() { return punktideArv; }
        public string Info() { return info; }
    }
}
