using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Database
{
    public class DisciplinaDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();


       public void Inserir(Models.TbDisciplina disciplina)
       {
           db.Add(disciplina);
           db.SaveChanges();
       }
       public bool ConsultarExistencia(Models.TbDisciplina disciplina)
       {
           bool existe = db.TbDisciplina.Any(x => x.NmDisciplina == disciplina.NmDisciplina);

           return existe ;
       }

        public List<Models.TbDisciplina> ConsultarDisciplina(string disci)
        {
            List<Models.TbDisciplina> exists =
            db.TbDisciplina.Where(t => t.NmDisciplina == disci).ToList();

            return exists;
        }
          public  void Alterar (Models.TbDisciplina disciplina)
        {
          Models.TbDisciplina alterar = db.TbDisciplina.FirstOrDefault(d => d.IdDisciplina == d.IdDisciplina);
        
        
          alterar.NmDisciplina = disciplina.NmDisciplina;
          alterar.DsSigla = disciplina.DsSigla;
          alterar.DtInclusao= disciplina.DtInclusao;
          alterar.BtAtivo= disciplina.BtAtivo;
          alterar.DtUltimaAlteracao = disciplina.DtUltimaAlteracao;
          db.SaveChanges();
          
        }
    }
}