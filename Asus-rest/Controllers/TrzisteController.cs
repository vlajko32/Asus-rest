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
    [Route("/api/trzista")]
    public class TrzisteController : Controller
    {
        private IUnitOfWork uow;

        public TrzisteController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        [HttpGet()]
        public IActionResult GetAll()
        {
            List<Trziste> trzista = uow.Trzista.GetAll();
            return Ok(trzista);
        }
    }
}
