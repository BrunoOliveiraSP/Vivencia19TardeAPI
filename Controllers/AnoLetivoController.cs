
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;


namespace Vivencia19TardeAPI_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnoLetivoController : ControllerBase
    {
        Vivencia19TardeAPI.Business.AnoLetivoBusiness db = new  Vivencia19TardeAPI.Business.AnoLetivoBusiness();

        [HttpPost]
        public void Inserir(Vivencia19TardeAPI.Models.TbAnoLetivo ano)
        {
            db.Inserir(ano);
        }

        [HttpPut]
        public void Alterar(Vivencia19TardeAPI.Models.TbAnoLetivo ano)
        {
            db.Alterar(ano);

        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);
        }

        [HttpGet]
        public List<Vivencia19TardeAPI.Models.TbAnoLetivo> ListarTodos ()
        {
            List<Vivencia19TardeAPI.Models.TbAnoLetivo> ano = db.ListarTodos();
            return ano;

        }
 
        

    }
}