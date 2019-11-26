using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vivencia19TardeAPI.Business
{
    
    public class CursoBusiness
    {
        Database.cursoDatabase db = new Database.cursoDatabase();
        
        public void Inserir (Models.TbCurso curso) 
        {
            if(curso.NmCurso == string.Empty)
            throw new ArgumentException("Campo vazio.");            

            if(curso.DsSigla == string.Empty)
            throw new ArgumentException("Campo vazio.");

            if(curso.NrCapacidadeMaxima == 0)
            throw new ArgumentException("Valor inválido.");

            if(curso.DsCategoria == string.Empty)
            throw new ArgumentException("Escolha uma opção."); 

            db.Inserir(curso);          
        }

        
      public void Alterar(Models.TbCurso curso)
      {
          if(curso.NmCurso == null)
          {
              throw new Exception("O nome do curso não pode ser vazio");
          }
          if(curso.NrCapacidadeMaxima == 0)
          {
              throw new Exception("O numero maximo não pode ser 0");
          }
          if(curso.DsSigla ==null)
          {
              throw new Exception("A sigla não pode ser vazia");
          }

          db.Alterar(curso);
      }  

      public void Remover(int id)
      {
          db.Remover(id);

      }
    }
}