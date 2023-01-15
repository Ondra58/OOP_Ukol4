using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class Tahac : NakladniAuto
    {
        private int nosnostVlecky;
        public int Hmotnostnakladu
        {
            get
            {
                return this.hmotnostnakladu;
            }

        }
        public Tahac(string spz, int nosnost, int nosnostVlecky) : base(spz, (int)(nosnost + nosnostVlecky))
        {
            this.nosnostVlecky = nosnostVlecky;
        }
        public new void NalozNaklad(int vaha)
        {
            base.NalozNaklad(vaha);
        }
        public new void VylozNaklad(int vaha)
        {
            base.VylozNaklad(vaha);
        }

        public new string ToString()
        {
            return base.ToString();
        }
    }
}
