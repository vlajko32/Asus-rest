using Asus_rest.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Models
{
    public class RadnikModel
    {
        [Required]
        public int SifraRadnika { get; set; }
        [Required]
        public string ImePrezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int TrzisteID{ get; set; }
    }
}
