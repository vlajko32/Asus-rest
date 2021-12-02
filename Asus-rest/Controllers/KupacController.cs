using Asus_rest.Domain;
using Asus_rest.Repository.uow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Controllers
{
    [ApiController]
    [Route("api/kupac")]
    public class KupacController : Controller
    {

        private IUnitOfWork uow;

        public KupacController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            List<Kupac> kupci = uow.Kupci.GetAll();
            return Ok(kupci);
        }

        [HttpGet("{PiB}")]
        public IActionResult GetKupac([FromRoute] string PiB)
        {
            Kupac kupac  = uow.Kupci.FindById(PiB);
            return Ok(kupac);
        }
    }
}
