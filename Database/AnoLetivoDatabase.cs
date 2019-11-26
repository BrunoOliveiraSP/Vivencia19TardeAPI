using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    public class AnoLetivoDatabase
    {

        Vivencia19TardeAPI.Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();  

        public void CadastrarAnoLetivo(Vivencia19TardeAPI.Models.TbAnoLetivo anoLetivo)
        {
            db.TbAnoLetivo.Add(anoLetivo);
            db.SaveChanges();
        }

        public List<Vivencia19TardeAPI.Models.TbAnoLetivo> ListarTodos()
        {
            List<Models.TbAnoLetivo> ano = db.TbAnoLetivo.ToList();
            return ano;
        }

        public void Remover(int id)
        {
            Models.TbAnoLetivo anos = db.TbAnoLetivo.FirstOrDefault(x => x.IdAnoLetivo == id);

            db.Remove(anos);
            db.SaveChanges();
        }

        public void Alterar(Models.TbAnoLetivo anoLetivo)
        {
            Models.TbAnoLetivo anos = db.TbAnoLetivo.FirstOrDefault(x => x.IdAnoLetivo == anoLetivo.IdAnoLetivo);

            anos.NrAno = anoLetivo.NrAno;
            anos.BtAtivo = anoLetivo.BtAtivo;
            anos.DtFim = anoLetivo.DtFim;
            anos.DtInicio = anoLetivo.DtInicio;
            anos.TpStatus = anoLetivo.TpStatus;

            db.SaveChanges();
        }
    }
}