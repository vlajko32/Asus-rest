using Asus_rest.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Models
{
    public class PorudzbenicaModel
    {

        [Required]
        public int porudzbenicaID { get; set; }
        [Required]
        public DateTime datumPor { get; set; }
        [Required]
        public string PiB { get; set; }

        public List<StavkaPorudzbenicce> stavkePorudzbenice { get; set; }
        [Required]

        public int sifraRadnika { get; set; }
    }
}
