using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Domain
{
    public class Porudzbenicca
    {
        public DateTime DatumPor { get; set; }

        public int PorudzbeniccaID { get; set; }

        public Kupac Kupac { get; set; }

        public string PiB { get; set; }

        public OdgovornoLice OdgovornoLice { get; set; }

        public int SifraRadnika { get; set; }

        public List<StavkaPorudzbenicce> StavkePorudzbenice { get; set; }

    }
}
