using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vivencia19TardeAPI.Business
{
    
    public class CursoBusiness
    {
      Database.cursoDatabase bd = new Database.cursoDatabase();

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

          bd.Alterar(curso);
      }  

      public void Remover(int id)
      {
          bd.Remover(id);

      }
    }
}