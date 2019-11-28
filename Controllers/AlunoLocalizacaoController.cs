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
    public class AlunoLocalizacaoController
    {
        
         Business.AlunoLocalizacaoBusiness Bus = new Business.AlunoLocalizacaoBusiness();
        
        [HttpPost]
        public void Inserir(Models.TbAlunoLocalizacao localizacao)
        {
            Bus.Inserir(localizacao);
        }

         [HttpGet]
         public List<Models.TbAlunoLocalizacao> Consultar()
         {
             List<Models.TbAlunoLocalizacao> lista= Bus.Consultar();
             return lista;
         }
         [HttpDelete]
         public void Deletar(int id)
         {
             Bus.Deletar(id);
             
         }
         [HttpPut]
         public void Alterar(int id,Models.TbAlunoLocalizacao localizacao)
         {
             Bus.Alterar(id, localizacao);
         }
      
    }
}
    
