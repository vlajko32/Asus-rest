using Asus_rest.Domain;
using Asus_rest.Models;
using Asus_rest.Repository.uow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Controllers
{
    [ApiController]
    [Route("api/radnik")]
    public class RadnikController : Controller
    {
        private IUnitOfWork uow;

        public RadnikController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] RadnikModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            OdgovornoLice lice = new OdgovornoLice
            {
                SifraRadnika = model.SifraRadnika,
                ImePrezime = model.ImePrezime,
                Email = model.Email,
                TrzisteID = model.TrzisteID,
                
            };
            try
            {
                uow.Radnici.Insert(lice);
                uow.Commit();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }


        [HttpGet()]
        public IActionResult GetAll()
        {
            List<OdgovornoLice> radnici = uow.Radnici.GetAll();
            return Ok(radnici);
        }

        [HttpGet("{id}")]
        public IActionResult GetRadnik([FromRoute] int id)
        {
            OdgovornoLice radnik = uow.Radnici.FindById(id);
            return Ok(radnik);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRadnik([FromRoute] int id)
        {
            OdgovornoLice radnik = uow.Radnici.FindById(id);
            uow.Radnici.Delete(radnik);
            uow.Commit();
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRadnik([FromRoute] int id, [FromBody] RadnikModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                OdgovornoLice radnik = uow.Radnici.FindById(id);
                radnik.Email = model.Email;
                radnik.ImePrezime = model.ImePrezime;
                radnik.TrzisteID = model.TrzisteID;
                uow.Radnici.Update(radnik, id);
                uow.Commit();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
