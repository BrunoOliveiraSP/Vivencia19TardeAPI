using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    
    public class AlunoResponsavelDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();

        public void Inserir(Models.TbAlunoResponsavel responsavel)
        {
            DB.TbAlunoResponsavel.Add(responsavel);
            DB.SaveChanges();
        }
        public List<Models.TbAlunoResponsavel> Consultar(int idAluno)
        {
            List<Models.TbAlunoResponsavel> lista =DB.TbAlunoResponsavel.Where(e=> e.IdAluno == idAluno).ToList();

            return lista;
        }
        public void Alterar(Models.TbAlunoResponsavel responsavel)
        {
            Models.TbAlunoResponsavel alterar = DB.TbAlunoResponsavel.FirstOrDefault(r => r.IdAluno ==responsavel.IdAluno);

            alterar.IdFuncionarioAlteracao = responsavel.IdFuncionarioAlteracao;
            alterar.NmResponsavel = responsavel.NmResponsavel;
            alterar.DsEmail = responsavel.DsEmail;
            alterar.DsParentesco = responsavel.DsParentesco;
            alterar.DsRg = responsavel.DsRg;
            alterar.DsTelefone1 = responsavel.DsTelefone1;
            alterar.DsTelefone2= responsavel.DsTelefone2;
            alterar.DtInclusao= responsavel.DtInclusao;
            alterar.DtUltimaAlteracao = responsavel.DtUltimaAlteracao;

            DB.SaveChanges();
        }
        public void Remove(int id)
        {
            Models.TbAlunoResponsavel remover =DB.TbAlunoResponsavel.FirstOrDefault(r => r.IdAluno == id);
            DB.Remove(remover);

            DB.SaveChanges();
        }
    }
}