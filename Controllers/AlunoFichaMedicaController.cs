using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{
    public class AlunoFichaMedicaController
    {
        Business.TbAlunoFichaMedicaBusiness Bus = new Business.TbAlunoFichaMedicaBusiness();
        
        [HttpPost]
        public void Inserir(TbAlunoFichaMedica fichaMedica)
        {
            Bus.Inserir(fichaMedica);
        }

         [HttpGet]
         public List<Models.TbAlunoFichaMedica> Consultar()
         {
             List<Models.TbAlunoFichaMedica> lista= Bus.Consultar();
             return lista;
         }
         [HttpDelete]
         public void Deletar(int id)
         {
             Bus.Deletar(id);
             
         }
         [HttpPut]
         public void Alterar(int id,TbAlunoFichaMedica fichaMedica)
         {
             Bus.Alterar(id, fichaMedica);
         }
    }
}