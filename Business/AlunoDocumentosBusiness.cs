using System.Collections;
using System.Collections.Generic;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoDocumentosBusiness
    {
        Database.AlunoDocumentosDatabase db = new Database.AlunoDocumentosDatabase();
        public void Inserir(Models.TbAlunoDocumentos documentos)
        {
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
        public void Deletar (int id)
        {
            db.Deletar(id);
        }

        
    }
}