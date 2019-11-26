using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class ModuloDisciplinaDataBase
    {
         Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void Inserir(Models.TbModuloDisciplina tb)
        {
            db.TbModuloDisciplina.Add(tb);
            db.SaveChanges();
        }
        public List<Models.TbModuloDisciplina> ConsultarTodos()
        {
            return db.TbModuloDisciplina.ToList();
        }
    }
}