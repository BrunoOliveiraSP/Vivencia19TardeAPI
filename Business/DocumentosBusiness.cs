using System.Collections;
using System.Collections.Generic;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class DocumentosBusiness
    {
        Database.DocumentosDatabase db = new Database.DocumentosDatabase();
        public void Inserir(Models.TbAlunoDocumentos documentos)
        {
            if(documentos.NmDocumento == string.Empty)
            {
                throw new ArgumentException("Nome é'obrigatorio ");
            }
            if(documentos.DtInclusao > DateTime.Now)
            {
                throw new ArgumentException("A data de inclusão não pode ser mais q a data de hoje");
            }
            
            db.Inserir(documentos);
        }
        public List<Models.TbAlunoDocumentos> Consultar(int id)
        {
            List<Models.TbAlunoDocumentos> lista = db.Consultar(id);

            return lista;
        }
        public void Alterar(Models.TbAlunoDocumentos documentos)
        {
            db.Alterar(documentos);
        }
        public void Remover (int id)
        {
            db.Deletar(id);
        }
    }
}