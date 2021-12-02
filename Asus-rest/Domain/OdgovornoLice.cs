using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Domain
{
    public class OdgovornoLice
    {

        public int SifraRadnika { get; set; }

        public string ImePrezime { get; set; }

        public string Email { get; set; }

        public int TrzisteID { get; set; }

        public Trziste Trziste { get; set; }
    }
}
