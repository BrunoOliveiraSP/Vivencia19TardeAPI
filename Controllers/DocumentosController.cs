using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class DocumentosController:ControllerBase
    {
        
        Business.DocumentosBusiness business = new Business.DocumentosBusiness();
        [HttpPost]
        public void Inserir (TbAlunoDocumentos documentos)
        {
            business.Inserir(documentos);
        }


        [HttpGet("{id}")]
        public List<TbAlunoDocumentos> Consultar(int id)
        {
           List<TbAlunoDocumentos> lista = business.Consultar(id);

           return lista;
        }



        [HttpPut]
        public void Alterar (TbAlunoDocumentos documentos)
        {
            business.Alterar(documentos);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            business.Remover(id);
        } 


    }
}