using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Domain
{
    public class StavkaPorudzbenicce
    {
        public int stavkaPorudzbenicceID { get; set; }

        public int porudzbenicaID { get; set; }

        public Porudzbenicca porudzbenica { get; set; }

        public int kolicina { get; set; }

        public int SifraProizvoda { get; set; }

        public Proizvod Proizvod { get; set; }

        public string status { get; set; }
    }
}
