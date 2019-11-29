using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploController : ControllerBase
    {
        static List<ExemploModel> lista = new List<ExemploModel>();
        static ExemploController()
        {
            for (int i = 0; i < 10; i++)
            {
                lista.Add(new ExemploModel
                {
                    Id = i,
                    Nome = "Exemplo " + i 
                });
            }
        }





        
        [HttpGet]
        public ActionResult<List<ExemploModel>> Listar()
        {
            try
            {
                return lista;    
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
            
        }

        public ActionResult Inserir(ExemploModel exemplo)
        {
            try
            {
                if (exemplo.Nome == "")
                    throw new ArgumentException("Nome não pode ser vazio.");

                lista.Add(exemplo);

                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

    }
}