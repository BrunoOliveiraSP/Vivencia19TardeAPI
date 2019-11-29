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
  
    public class SalaVestibularController : ControllerBase  
    {
        Business.SalaVestibularBusiness business = new Business.SalaVestibularBusiness();

        [HttpPost("Inserir")]
        public void Inserir(Models.TbSalaVestibular sala)
        {
            business.Inserir(sala);
        }

        [HttpDelete("Remover/{id}")]
        public void Remover(int id)
        {
            business.Remover(id);
        }

        [HttpPut("Alterar")]
        public void ALterar(Models.TbSalaVestibular sala)
        {
            business.Alterar(sala);
        }

        [HttpGet("ListarTudo")]
        public List<Models.TbSalaVestibular> ListarTudo()
        {
            List<Models.TbSalaVestibular> consulta = business.ListarTudo();
            return consulta;
        }
    }
}