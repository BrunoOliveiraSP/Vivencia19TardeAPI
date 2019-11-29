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
       public bool ConsultarExistenciaDS(Models.TbDisciplina disciplina)
       {
           bool existe = db.TbDisciplina.Any(x => x.DsSigla == disciplina.DsSigla);

           return existe ;
       }
          public  void Alterar (Models.TbDisciplina disciplina)
        {
          Models.TbDisciplina alterar = db.TbDisciplina.FirstOrDefault(d => d.IdDisciplina == disciplina.IdDisciplina);
        
        
          alterar.NmDisciplina = disciplina.NmDisciplina;
          alterar.DsSigla = disciplina.DsSigla;
          alterar.DtInclusao= disciplina.DtInclusao;
          alterar.BtAtivo= disciplina.BtAtivo;
          alterar.DtUltimaAlteracao = disciplina.DtUltimaAlteracao;
      
      
          db.SaveChanges();
          
        }
        public void Deletar(int id)
        {
            Models.TbDisciplina delete = db.TbDisciplina.FirstOrDefault(x => x.IdDisciplina == id);
            db.TbDisciplina.Remove(delete);
            db.SaveChanges();
        }
        public List<Models.TbDisciplina> ListaTodos()
        {
          List<Models.TbDisciplina> lista = db.TbDisciplina.ToList();
          return lista;
        }
    }
}