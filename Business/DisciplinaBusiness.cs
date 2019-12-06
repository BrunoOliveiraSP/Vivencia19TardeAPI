using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;


namespace Vivencia19TardeAPI.Business
{

    public class DisciplinaBusiness
    {

        Database.DisciplinaDatabase db = new Database.DisciplinaDatabase();

        public void Inserir(Models.TbDisciplina disciplina)
        {
           bool existe = db.ConsultarExistenciaNome(disciplina);
           bool existesigla = db.ConsultarExistenciaDS(disciplina);
           string sigla = disciplina.DsSigla;
           

            if(existe)
            {
                throw new ArgumentException(" Essa disciplina já existe");
            }
            if(disciplina.NmDisciplina.Length > 30)
            {
                 throw new ArgumentException("Nome Da disciplina é muito extensa");
            }
             if(disciplina.DsSigla.Length > 30)
             {
                 throw new ArgumentException("A sigla é muito extensa");
             }
             if(disciplina.NmDisciplina.Length < 5)
             {
                 throw new ArgumentException("Nome é obrigatório");
             }
             if(disciplina.DsSigla.Length < 2)
             {
                 throw new ArgumentException("Sigla obrigatória");
             }
             if(existesigla)
             {
               throw new ArgumentException(" Essa sigla já existe");
             }
            
               db.Inserir(disciplina);
             
        }

          public  void Alterar (Models.TbDisciplina disciplina)
          {
              
           bool existe = db.ConsultarExistenciaNome(disciplina);
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
            if(existeDS)
            {
                throw new ArgumentException("Esta alteração não pode ser feita, a Sigla já existe");
            }
            if(disciplina.NmDisciplina.Length < 5)
             {
                 throw new ArgumentException("Nome é obrigatório");
             }
             if(disciplina.DsSigla.Length < 2)
             {
                 throw new ArgumentException("Sigla obrigatória");
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
          public BindingList<Models.TbDisciplina> ListarCursoDisciplina(int id)
          {
              return db.ListarDiciplinasDeCursos(id);
          }
          public void InserirDisciplinasCurso(int idcurso, int iddisciplina)
          {
              db.InserirDisciplinasCurso(idcurso, iddisciplina);
          }
          public void RemoverCursoDisciplina(int idcurso)
          {
              db.RemoverCursoDisciplinaCurso(idcurso);
          }
    }          
}