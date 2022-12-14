using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class NakladniAuto
    {
        protected string spz;
        protected int nosnost;
        protected int hmotnostnakladu = 0;
        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        protected virtual void NalozNaklad(int vaha)
        {
            if (vaha > nosnost - hmotnostnakladu)
            {
                MessageBox.Show("Nenaložilo se " + (vaha - (nosnost - hmotnostnakladu)) + " tun.");
                hmotnostnakladu += (int)(nosnost - hmotnostnakladu);
            }
            else
            {
                hmotnostnakladu += vaha;
            }
        }
        protected virtual void VylozNaklad(int vaha)
        {
            if (vaha <= hmotnostnakladu)
            {
                hmotnostnakladu = hmotnostnakladu - vaha;
            }
            else
            {
                hmotnostnakladu = 0;
                MessageBox.Show("Není možné vyložit tolik tun nákladu. Chybí " + (vaha - hmotnostnakladu) + " tun.");
            }
        }
        protected new virtual string ToString()
        {
            return "Nákladní auto " + spz + " má nosnost " + nosnost + " tuny a má naloženo " + hmotnostnakladu + " tun.";
        }
    }
}
