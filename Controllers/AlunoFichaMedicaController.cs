using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoFichaMedicaController: ControllerBase
    {
        Business.AlunoFichaMedicaBusiness bus = new Business.AlunoFichaMedicaBusiness();
        
        [HttpPost]
        public void Inserir(TbAlunoFichaMedica fichaMedica)
        {
            bus.Inserir(fichaMedica);
        }

         [HttpGet]
         public List<Models.TbAlunoFichaMedica> Consultar()
         {
             List<Models.TbAlunoFichaMedica> lista = bus.Consultar();
             return lista;
         }

         [HttpDelete]
         public void Deletar(int id)
         {
             bus.Deletar(id);
             
         }
         
         [HttpPut]
         public void Alterar(int id,TbAlunoFichaMedica fichaMedica)
         {
             bus.Alterar(fichaMedica);
         }
    }
}