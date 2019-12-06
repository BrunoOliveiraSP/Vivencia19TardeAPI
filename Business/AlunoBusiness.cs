using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoBusiness
    {
        Database.AlunoDatabase DB = new Database.AlunoDatabase();
        public void inserir(Models.TbAluno aluno)
        {
           this.validacao(aluno);
           DB.inserir(aluno);
        }
        public List<Models.TbAluno> ConsultarPorNome(string nome)
        {
           List<Models.TbAluno> lista = DB.ConsultarPorNome(nome);

           return lista;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno Model = DB.Carregar(aluno);
            return Model;
        }
        public void Alterar(Models.TbAluno nova)
        {
           this.validacao(nova);
           DB.Alterar(nova);
        }

        public void Deletar(int id)
        {
            DB.Deletar(id);
        }

        public Models.TbAluno consular (Models.TbAluno aluno)
        {
            return DB.consultar(aluno);
        }

        private void validacao (Models.TbAluno aluno)
        {

            Models.TbAluno Individuo = DB.Carregar(aluno);
            int diferença = Convert.ToInt32(DateTime.Now.Year - aluno.DtNascimento.Year);

            if (aluno.NmAluno == string.Empty)
            throw new ArgumentException("O campo de Nome é obrigatorio");

            if (aluno.NmEscola == string.Empty)
            throw new ArgumentException("O campo Escola é obrigatorio");

            else if (aluno.DsCpf.Length != 14 && aluno.DsCpf == null)
            throw new ArgumentException ("Este CPF esta invalido");

            else if (aluno.DsEmail.Contains("@") == false && aluno.DsEmail.Contains(".com") == false)
            throw new ArgumentException ("Este Email esta invalido");

            else if (aluno.DsEmail == string.Empty)
            throw new ArgumentException ("O campo de Email é obrigatorio");

            else if (aluno.DsRg.Length != 10)
            throw new ArgumentException("O RG esta invalido");

            else if (aluno.DsRg == string.Empty)
            throw new ArgumentException("O campo de RG é obrigatorio");

            else if (aluno.DtEmissao == null)
            throw new ArgumentException("O campo de Emissão é obrigatorio");

            else if (aluno.DtNascimento == null)
            throw new ArgumentException("O campo de Data de Nascimento é obrigatorio");

            else if (diferença <=14 || diferença >=25 )
            throw new ArgumentException("O individuo não tem a idade necessária para ingressar no curso");
        }
    }
}