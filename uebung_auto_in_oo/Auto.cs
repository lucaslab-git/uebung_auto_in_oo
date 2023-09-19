using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace uebung_auto_in_oo
{
    internal class Auto
    {
        private string farbe;
        private int preis;

        public int getPreis()
        {
            return preis;
        }
        public string getFarbe()
        {
            return farbe;
        }

        public void setPreis(int pPreis)
        {
            preis = pPreis;
        }

        public void setFarbe(string pfarbe)
        {
            farbe = pfarbe;
        }
    }
}
