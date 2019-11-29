using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    public class ModuloDatabase
    {
         Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void Inserir(Models.TbModulo tb)
        {
            db.TbModulo.Add(tb);
            db.SaveChanges();
        }
        public List<Models.TbModulo> ConsultarTodos()
        {
            return db.TbModulo.ToList();
        }
        public void Alterar(Models.TbModulo modulo)
        {
            Models.TbModulo alt = db.TbModulo.FirstOrDefault(x => x.IdModulo == modulo.IdModulo
                                                          || x.IdAnoLetivo == modulo.IdAnoLetivo);
            
            alt.TpModulo = modulo.TpModulo;
            alt.NmModulo = modulo.NmModulo;
            alt.NrModulo = modulo.NrModulo;
            alt.DtInicio = modulo.DtInicio;
            alt.DtFinal = modulo.DtFinal;
            alt.BtAberto = modulo.BtAberto;

            db.SaveChanges();
        }
         public void Remover(int id)
        {
            Models.TbModulo del = db.TbModulo.FirstOrDefault(x => x.IdModulo == id);

            db.Remove(del);
            db.SaveChanges();
        }

    }
}