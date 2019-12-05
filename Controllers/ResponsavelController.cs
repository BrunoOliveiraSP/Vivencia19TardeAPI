using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Vivencia19TardeAPI.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class ResponsavelController
    {
        Business.AlunoResponsavelBusiness business = new Business.AlunoResponsavelBusiness();
        [HttpPost]
        public void Inserir(Models.TbAlunoResponsavel responsavel)
        {
            business.Inserir(responsavel);
        }
        [HttpGet("{id}")]
        public List<Models.TbAlunoResponsavel> Consultar(int id)
        {
           List<Models.TbAlunoResponsavel> lista = business.Consultar(id);

           return lista;
        }
        [HttpPut]
        public void Alterar (Models.TbAlunoResponsavel responsavel)
        {
            business.Alterar(responsavel);
        }
        [HttpDelete("{id}")]
        public void Deletar(int id)
        {
            business.Deletar(id);
        }
    }
}