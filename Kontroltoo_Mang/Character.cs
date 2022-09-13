using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroltoo_Mang
{
    internal class Character : IEntity
    {
        string nimi;
        List<Ese> tegelased;

        public Character(string nimi, List<Ese> tegelased)
        {
            this.nimi = nimi;
            this.tegelased = tegelased;
        }

    }
}
