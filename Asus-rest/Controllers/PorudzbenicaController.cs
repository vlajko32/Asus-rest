using Asus_rest.Domain;
using Asus_rest.Models;
using Asus_rest.Repository.uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Controllers
{
    [Route("api/porudzbeenica")]
    [ApiController]
    public class PorudzbenicaController : Controller
    {
        private IUnitOfWork uow;

        public PorudzbenicaController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] PorudzbenicaModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Porudzbenicca porudzbenica = new Porudzbenicca
            {
                PorudzbeniccaID = model.porudzbenicaID,
                DatumPor = model.datumPor,
                StavkePorudzbenice = model.stavkePorudzbenice,
                SifraRadnika = model.sifraRadnika,
                PiB = model.PiB
               

            };
            try
            {
                uow.Porudzbenice.Insert(porudzbenica);
                uow.Commit();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }


        [HttpGet()]
        public IActionResult GetAll()
        {
            List<Porudzbenicca> porudzbenice = uow.Porudzbenice.GetAll();
            return Ok(porudzbenice);
        }

        [HttpGet("{id}")]
        public IActionResult GetPorudzbenicca([FromRoute] int id)
        {
            Porudzbenicca porudzbenicca = uow.Porudzbenice.FindById(id);
            return Ok(porudzbenicca);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePorudzbenicca([FromRoute] int id)
        {
            Porudzbenicca porudzbenicca = uow.Porudzbenice.FindById(id);
            uow.Porudzbenice.Delete(porudzbenicca);
            uow.Commit();
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult UpdatePorudzbenicca([FromRoute] int id, [FromBody] PorudzbenicaModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Porudzbenicca porudzbenicca = uow.Porudzbenice.FindById(id);
                    porudzbenicca.DatumPor = model.datumPor;
                porudzbenicca.StavkePorudzbenice = model.stavkePorudzbenice;
                porudzbenicca.SifraRadnika = model.sifraRadnika;
                porudzbenicca.PiB = model.PiB;
                uow.Porudzbenice.Update(porudzbenicca, id);
                uow.Commit();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
