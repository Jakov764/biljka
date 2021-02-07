using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovBiljka
{
    class Stablo : Biljka
    {
        public bool opadajuListovi;

        public bool OpadajuListovi()
        {
            return opadajuListovi;
        }

        Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
}
