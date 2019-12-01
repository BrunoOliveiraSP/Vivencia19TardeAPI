using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    
    public class DocumentosDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();

        public void Inserir (Models.TbTurmaAluno Matricula)
        {
            DB.Add(Matricula);
            DB.SaveChanges();
        }    

        public List<Models.TbAlunoDocumentos> ListarTodos ()
        {
            List<Models.TbAlunoDocumentos> Lista = DB.TbAlunoDocumentos.ToList();
            return Lista;
        }
    }
}