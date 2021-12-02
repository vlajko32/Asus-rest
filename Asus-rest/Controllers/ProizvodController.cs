using Asus_rest.Domain;
using Asus_rest.Repository.uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Controllers
{
    [Route("api/proizvod")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private IUnitOfWork uow;

        public ProizvodController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet("{id}")]
        public IActionResult GetProizvod([FromRoute] int id)
        {
            Proizvod proizvod = uow.Proizvodi.FindById(id);
            return Ok(proizvod);
        }
    }
}
