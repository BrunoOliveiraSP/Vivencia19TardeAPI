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
        Database.CursoDatabase db = new Database.CursoDatabase();
        
        public void Inserir (Models.TbCurso curso) 
        {
            bool contemCurso = db.ContemSigla(curso.NmCurso);
            bool contemSigla = db.ContemSigla(curso.DsSigla);

            if(curso.NmCurso == string.Empty)
            throw new ArgumentException("Campo não pode estar vazio.");  

            if(curso.DsSigla == string.Empty)
            throw new ArgumentException("Campo não pode estar vazio.");

            if(contemCurso == true)
            throw new ArgumentException("Curso já cadastrado.");           

            if(contemSigla == true)
            throw new ArgumentException("Sigla já cadastrado.");

            if(curso.NrCapacidadeMaxima == 0)
            throw new ArgumentException("Valor inválido.");

            if(curso.DsCategoria == string.Empty)
            throw new ArgumentException("Escolha uma opção."); 

            db.Inserir(curso);    

                  
        }

        
      public void Alterar(Models.TbCurso curso)
      {
          bool contemCurso = db.ContemSigla(curso.NmCurso);
            bool contemSigla = db.ContemSigla(curso.DsSigla);

            if(curso.NmCurso == string.Empty)
            throw new ArgumentException("Campo não pode estar vazio.");  

            if(curso.DsSigla == string.Empty)
            throw new ArgumentException("Campo não pode estar vazio.");

            if(contemCurso == true)
            throw new ArgumentException("Curso já cadastrado.");           

            if(contemSigla == true)
            throw new ArgumentException("Sigla já cadastrado.");

            if(curso.NrCapacidadeMaxima == 0)
            throw new ArgumentException("Valor inválido.");

            if(curso.DsCategoria == string.Empty)
            throw new ArgumentException("Escolha uma opção."); 

          db.Alterar(curso);
      }  

      public void Remover(int id)
      {
          db.Remover(id);

      }
        public List<Models.TbCurso> ConsultarPorNome(String NomeCurso)
        {
             return db.ConsultarPorNome(NomeCurso);
        }

        public List<Models.TbCurso> ConsultarPorSigla(String Sigla)
        {
             return db.ConsultarPorSigla(Sigla);
        }

        public List<Models.TbCurso> ListarTodos()
        {
             return db.ListarTodos();
        }


        // Pessoal Matricula
        public Models.TbCurso ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public Models.TbCurso ConsultarCurso(int id)
        {
            if(id == 0)
               throw new ArgumentException("Informe o curso.");

            return db.ConsultarCurso(id);   
        }
    }
}