using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;


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
       public bool ConsultarExistenciaNome(Models.TbDisciplina disciplina)
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
          List<Models.TbDisciplina> lista = db.TbDisciplina.OrderBy(alf => alf.NmDisciplina).ToList();
          return lista;
        }
        public List<Models.TbDisciplina> ListarNomeSigla(string nome, string sigla)
        {
            List<Models.TbDisciplina> lista = db.TbDisciplina.Where(x => 
                      x.NmDisciplina.Contains(nome) || 
                      x.DsSigla.Contains(sigla)).ToList();

             return  lista;
        }
        public List<Models.TbDisciplina> ListarDiciplinasDeCursos(int idcurso)
        {
            List<Models.TbCursoDisciplina> ids = db.TbCursoDisciplina.Where( x => x.IdCurso == idcurso).ToList();

            List<Models.TbDisciplina> Disciplinas = new List<Models.TbDisciplina>();
            
            foreach(Models.TbCursoDisciplina item in ids)
            {
                List<Models.TbDisciplina> Disciplina = db.TbDisciplina.Where(x => x.IdDisciplina == item.IdDisciplina).ToList();

                Disciplinas.AddRange(Disciplina);

            } 
            return Disciplinas;
        }
        public void InserirDisciplinasCurso(Models.TbCursoDisciplina mod)
        {
           db.Add(mod);
           db.SaveChanges();
        }
        public void RemoverCursoDisciplinaCurso(int idcurso)
        {
            List<Models.TbCursoDisciplina> cd = db.TbCursoDisciplina.Where(x => x.IdCurso == idcurso).ToList();
             
            foreach (var item in cd)
            {
              db.TbCursoDisciplina.Remove(item);
              db.SaveChanges();
            }   
        }
    }
}