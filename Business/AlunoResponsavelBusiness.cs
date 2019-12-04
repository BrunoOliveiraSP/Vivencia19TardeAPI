using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business 
{
    public class AlunoResponsavelBusiness
    {
        
        Database.AlunoResponsavelDatabase db = new Database.AlunoResponsavelDatabase();

        public void Inserir(Models.TbAlunoResponsavel responsavel)
        {
            this.Validacao(responsavel);

            db.Inserir(responsavel);
        }
        public List<Models.TbAlunoResponsavel> Consultar(int id)
        {
            List<Models.TbAlunoResponsavel> lista =db.Consultar(id);

            return lista;
        }
        public void Alterar(Models.TbAlunoResponsavel responsavel)
        {
            this.Validacao(responsavel);

            db.Alterar(responsavel);
        }
        public void Deletar(int id)
        {
            db.Remove(id);
        }

        public void Validacao(Models.TbAlunoResponsavel ModelAlunoResponsavel)
        {
            if(ModelAlunoResponsavel.DsEmail.Contains("@") == false && ModelAlunoResponsavel.DsEmail.Contains(".com") == false)
            {   
                throw new Exception("Este Email esta inválido");
            }
            else if(ModelAlunoResponsavel.DsEmail == string.Empty)
            {
                throw new Exception("E-mail é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsParentesco == string.Empty)
            {
                throw new Exception("Parentesco é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsRg == string.Empty)
            {
                throw new Exception("Rg é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsTelefone1 == string.Empty)
            {
                throw new Exception("Telefone 1 é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsTelefone2 == string.Empty)
            {
                throw new Exception("Telefone 2 é obrigatório");
            }
            else if(ModelAlunoResponsavel.NmResponsavel == string.Empty)
            {
                throw new Exception("Responsavel é obrigatório");
            }
        }
    }
}