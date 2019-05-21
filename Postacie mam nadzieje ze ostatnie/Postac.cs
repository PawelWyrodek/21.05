using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postacie_mam_nadzieje_ze_ostatnie
{
    public class Postac
    {
        string imie;
        string hp;

        public Postac(string imie, string hp)
        {
            this.imie = imie;
            this.hp = hp;
        }

        public string PrzedstawSie()
        {
            return "Nazwyam się " + imie;
        }
    }
}
