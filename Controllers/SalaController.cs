using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;


namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaController : ControllerBase
    {
        Business.SalaBusiness business = new Business.SalaBusiness();

        [HttpPost("Inserir")]       
         public void Inserir(Models.TbSala sala)
        {
            business.Inserir(sala);
        }

        [HttpGet("ListarTudo")]      
        public List<Models.TbSala> ListarTudo()
        {
            List<Models.TbSala> sala = business.ListarTudo();
            return sala;

        }
                
    }
}