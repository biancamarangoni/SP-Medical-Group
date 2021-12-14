using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP_MedicalGroup.Context;
using SP_MedicalGroup.Domains;
using SP_MedicalGroup.Interfaces;
using SP_MedicalGroup.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        SPMediContext ctx = new SPMediContext();

        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpPost]
        public IActionResult Post(Consultum consulta)
        {
            try
            {
                //chama o método
                _consultaRepository.Consulta(consulta);

                //retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost]
        public IActionResult CancelarAgendamento(int id, Consultum consultaCancelada)
        {
            
            try
            {
                _consultaRepository.CancelarConsulta(id, consultaCancelada);

                return StatusCode(302);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult ListarConsultas()
        {
            try
            {
                return Ok(_consultaRepository.ListarConsultas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}      