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
         
            string disci = disciplina.NmDisciplina;

             if(disci.Length > 30)
             {
                 throw new ArgumentException("O nome da Disciplina é muito extensa");
             }

             if(disciplina.DsSigla.Length > 30 )
             {
                 throw new ArgumentException("A sigla é muito extensa");
             }
             

            // string exists = disciplina.NmDisciplina;
            // List<Models.TbDisciplina> vali = db.ConsultarDisciplina(exists);

            // if ( vali.Exists(t => t.NmDisciplina.Equals(exists)))
            // {
            //     throw new ArgumentException("Está Alteração não pode ser feita. A Disciplina já existe.");
            // }
             
            db.Alterar(disciplina);

          }
    }
}