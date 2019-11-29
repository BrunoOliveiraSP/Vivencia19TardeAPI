using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Business
{

    public class DisciplinaBusiness
    {

        Database.DisciplinaDatabase db = new Database.DisciplinaDatabase();

        public void Inserir(Models.TbDisciplina disciplina)
        {
           bool existe = db.ConsultarExistencia(disciplina);
            

            if(existe)
            {
                throw new ArgumentException("Disciplina já existe");
            }
            

            string sigla = disciplina.NmDisciplina;

             if(sigla.Length > 30)
             {
                 throw new ArgumentException("A sigla é muito extensa");
             }
            
               db.Inserir(disciplina);
             
        }

          public  void Alterar (Models.TbDisciplina disciplina)
          {
              
           bool existe = db.ConsultarExistencia(disciplina);
           bool existeDS = db.ConsultarExistenciaDS(disciplina);
           string disci = disciplina.NmDisciplina;

         
             if(disci.Length > 30)
             {
                 throw new ArgumentException("O nome da Disciplina é muito extensa");
             }

             if(disciplina.DsSigla.Length > 30 )
             {
                 throw new ArgumentException("A sigla é muito extensa");
             }
             
            if(disciplina.DsSigla == string.Empty )
             {
                 throw new ArgumentException("Informe uma sigla");
             }
             
            if(disciplina.NmDisciplina == string.Empty )
             {
                 throw new ArgumentException("Informe o nome da disciplina");
             }

            if(existe)
            {
                throw new ArgumentException("Esta alteração não pode ser feita, a Disciplina já existe");
            }

            if(existeDS)
            {
                throw new ArgumentException("Esta alteração não pode ser feita, a Sigla já existe");
            }
             
             
            db.Alterar(disciplina);

          }

          public List<Models.TbDisciplina> ListarTodos()
          {
             return db.ListaTodos();
          }
          public void Deletar(int id)
          {
              db.Deletar(id);
          }
          public List<Models.TbDisciplina> ListarNomeSigla(string nome, string sigla)
          {

              
             return db.ListarNomeSigla(nome, sigla);
          }
    }          
}