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
        public void Alterar(Models.TbModuloDisciplina tb)
        {
            Models.TbModuloDisciplina alt = db.TbModuloDisciplina.FirstOrDefault(x => x.id_modulo_disciplina == tb.id_modulo_disciplina);

            alt.id_disciplina = tb.id_disciplina;
            alt.id_curso = tb.id_curso;
            alt.id_modulo = tb.id_modulo;

            db.SaveChanges();
        }
        public void Remover(int id)
        {
            Models.TbModuloDisciplina del = db.TbModuloDisciplina.FirstOrDefault(x => x.id_modulo_disciplina == id);

            db.Remove(del);
            db.SaveChanges();
        }
    }
}