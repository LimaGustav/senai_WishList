using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_WishListWebApi.Domains;
using senai_WishListWebApi.Interfaces;
using senai_WishListWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_WishListWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DesejosController : ControllerBase
    {
        private IDesejoRepository _desejoRepository { get; set; }

        public DesejosController()
        {
            _desejoRepository = new DesejoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_desejoRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Desejo novoDesejo)
        {
            try
            {
                bool created = _desejoRepository.Cadastrar(novoDesejo);

                if (created) return StatusCode(201);

                return NotFound(
                        new
                        {
                            mensagem = "Não foi possivel cadastrar o Desejo",
                            erro = true
                        }
                    );
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
