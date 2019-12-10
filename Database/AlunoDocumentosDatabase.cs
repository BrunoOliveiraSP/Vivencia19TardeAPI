using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    
    public class AlunoDocumentosDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void Inserir (Models.TbAlunoDocumentos aa )
        {
            db.TbAlunoDocumentos.Add(aa);
            db.SaveChanges();
        }    
        public List<Models.TbAlunoDocumentos> Consultar(int id )
        {
            List<Models.TbAlunoDocumentos> lista = db.TbAlunoDocumentos.Where(a=> a.IdAluno == id).ToList();

            return lista;
        }
        public void Alterar (Models.TbAlunoDocumentos documentos)
        {
            Models.TbAlunoDocumentos alterar =db.TbAlunoDocumentos.FirstOrDefault(a => a.IdAluno == documentos.IdAluno);
            alterar.NmDocumento = documentos.NmDocumento;
            alterar.DtUltimaAlteracao = documentos.DtUltimaAlteracao;
            alterar.DtInclusao = documentos.DtInclusao;
            alterar.BtEntregue = documentos.BtEntregue;
            alterar.IdAluno = documentos.IdAluno;
            alterar.IdFuncionarioAlteracao = documentos.IdFuncionarioAlteracao;

            db.SaveChanges();
        }
        public void Deletar(int id)
        {
            Models.TbAlunoDocumentos remover =db.TbAlunoDocumentos.FirstOrDefault(r=> r.IdAluno == id);

             if(remover != null)
            {
                db.Remove(remover);
                db.SaveChanges();
            }
        }

    }
}