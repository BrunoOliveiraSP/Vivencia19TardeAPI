using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

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
        public void Alterar(Models.TbModuloDisciplina tb)
        {
            TbModuloDisciplina alt = db.TbModuloDisciplina.FirstOrDefault(x => x.IdModuloDisciplina ==
                                                                              tb.IdModuloDisciplina);

            alt.IdDisciplina = tb.IdDisciplina;
            alt.IdCurso = tb.IdCurso;
            alt.IdModulo = tb.IdModulo;

            db.SaveChanges();
        }
        public void Remover(int id)
        {
            Models.TbModuloDisciplina del = db.TbModuloDisciplina.FirstOrDefault(x => x.IdModuloDisciplina == id);

            db.Remove(del);
            db.SaveChanges();
        }
    }
}