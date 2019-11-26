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
    }
}