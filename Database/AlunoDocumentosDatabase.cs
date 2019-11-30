using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    
    public class AlunoDocumentosDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();

        public void Inserir (Models.TbAlunoDocumentos aa )
        {
            DB.TbAlunoDocumentos.Add(aa);
            DB.SaveChanges();
        }    
        public List<Models.TbAlunoDocumentos> Consultar(int id )
        {
            List<Models.TbAlunoDocumentos> lista = DB.TbAlunoDocumentos.Where(a=> a.IdAluno == id).ToList();

            return lista;
        }
        public void Alterar (Models.TbAlunoDocumentos documentos)
        {
            Models.TbAlunoDocumentos alterar =DB.TbAlunoDocumentos.FirstOrDefault(a => a.IdAluno == documentos.IdAluno);
            alterar.NmDocumento = documentos.NmDocumento;
            alterar.DtUltimaAlteracao = documentos.DtUltimaAlteracao;
            alterar.DtInclusao = documentos.DtInclusao;
            alterar.BtEntregue = documentos.BtEntregue;
            alterar.IdAluno = documentos.IdAluno;
            alterar.IdFuncionarioAlteracao = documentos.IdFuncionarioAlteracao;

            DB.SaveChanges();
        }
        public void Deletar(int id)
        {
            Models.TbAlunoDocumentos remover =DB.TbAlunoDocumentos.FirstOrDefault(r=> r.IdAluno == id);
            DB.TbAlunoDocumentos.Remove(remover);
            DB.SaveChanges();
        }

    }
}