using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class ProfessorBusiness
    {
        Database.ProfessorDatabase db = new Database.ProfessorDatabase();
        public void Inserir(Models.ProfessorRequest prof)
        {
            Models.TbProfessor professor = new Models.TbProfessor();
            if (string.IsNullOrEmpty(prof.Professor.NmProfessor))
                throw new Exception("O Campo 'NOME' esta Invalido!");

            
            this.Validador(professor);    
                
        
            prof.Login.IdRole = 1;
            prof.Login.BtTrocar = true;
            prof.Login.DsSenha = "1234";
            prof.Login.DtInclusao = DateTime.Now;
            prof.Login.DtUltimoLogin = DateTime.Now;
            
            db.Inserir(prof.Login);

            prof.Professor.IdLogin = prof.Login.IdLogin;
            db.Inserir(prof.Professor);
        }

        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> lista = db.ListarTodos();
            return lista;
        }

        public List<Models.TbProfessor> ConsultarPorNome(string nome)
        {
            List<Models.TbProfessor> lista = db.ConsultarPorNome(nome);
            return lista;
        }

        public void Remover(int idProfessor,int idLogin )
        {
            db.RemoverProfessor(idProfessor);
            db.RemoverLogin(idLogin);
        }

        public void Alterar(Models.ProfessorRequest prof)
        {
            db.AlterarProfessor(prof.Professor);
            
            prof.Login.BtTrocar = true;
            prof.Login.DtInclusao = DateTime.Now;
            prof.Login.DtUltimoLogin = DateTime.Now;
            prof.Login.IdRole = 1;

            db.AlterarLogin(prof.Login);
        }  
        



        //Validações


         private void Validador(Models.TbProfessor professor)
         {
             if (professor.DsCelular == string.Empty)
                 throw new ArgumentException("O Campo de Celular é Obrigatório");
             if(professor.DsTelefone == string.Empty)
                 throw new ArgumentException("O Campo de Telefone é Obrigatório");
             if(professor.DsEstado == string.Empty)
                 throw new ArgumentException("O Campo de Estado é Obrigatório");
             if(professor.DsCvLattes == string.Empty)
                 throw new ArgumentException("O Campo de CvLattes é Obrigatório");
             if(professor.DsCpf == string.Empty)
                 throw new ArgumentException("O Campo de CPF é Obrigatório");
             if(professor.DsRg == string.Empty)
                 throw new ArgumentException("O Campo de RG é Obrigatório");
             if(professor.DsRgOrgao  == string.Empty)
                 throw new ArgumentException("O Campo de Orgão do RG é Obrigatório");
             if(professor.DsRgEmissor  == string.Empty)
                 throw new ArgumentException("O Campo do Emissor do RG é Obrigatório");
             if(professor.NmMae  == string.Empty)
                 throw new ArgumentException("O Campo do Nome da Mãe é Obrigatório");
             if(professor.NmPai == string.Empty)
                 throw new ArgumentException("O Campo do Nome da Pai é Obrigatório");
             if(professor.TpContratacao  == string.Empty)
                 throw new ArgumentException("O Campo do Tipo da Contratação é Obrigatório");
             if(professor.DsFaculdade  == string.Empty)
                 throw new ArgumentException("O Campo da Faculdade é Obrigatório");
             if(professor.DsCurso  == string.Empty)
                 throw new ArgumentException("O Campo de Curso é Obrigatório");
             if(professor.DsEmail == string.Empty)
                throw new ArgumentException("O Campo de Email é Obrigatório");
         }

      
         

    }
}