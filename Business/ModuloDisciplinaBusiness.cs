using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Business
{
    public class ModuloDisciplinaBusiness
    {
        Database.ModuloDisciplinaDataBase db = new Database.ModuloDisciplinaDataBase();
        public void Inserir(Models.TbModuloDisciplina tb)
        {
            if(tb.IdCurso <= 0 || tb.IdDisciplina <= 0 || tb.IdModulo <= 0 )
            {
                throw new ArgumentException("Informa��es Ivalidas.");
            }
            db.Inserir(tb);
        }
        public List<Models.TbModuloDisciplina> ListaTodos()
        {
            return db.ConsultarTodos();
        }
        public void Alterar(Models.TbModuloDisciplina tb)
        {
            db.Alterar(tb);
        }
        public void Deletar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID Ivalido.");
            }
            db.Remover(id);
        }
    }
}