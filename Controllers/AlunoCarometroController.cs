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
    public class AlunoCarometroController
    {
        Business.AlunoCarometroBusiness bus = new Business.AlunoCarometroBusiness();

        [HttpPost]
        public void Inserir (Models.TbAlunoCarometro carometro)
        {
            bus.Inserir(carometro);
        }

        [HttpGet]
        public List<Models.TbAlunoCarometro> ListarTodos()
        {
            return bus.ListarTodos();
        }

        [HttpPut]
        public void Alterar (Models.TbAlunoCarometro carometro)
        {
            bus.Alterar(carometro);
        }

        [HttpDelete]
        public void Deletar (int id)
        {
            bus.Deletar(id);
        }
    }
}