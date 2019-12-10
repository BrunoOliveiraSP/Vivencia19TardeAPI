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

        public void Cadastrar(Vivencia19TardeAPI.Models.TbAnoLetivo anoLetivo)
        {
            db.TbAnoLetivo.Add(anoLetivo);
            db.SaveChanges();
            Models.ModelIDAnoLetivo t = new Models.ModelIDAnoLetivo();
            t.IdAnoLetivo = anoLetivo.IdAnoLetivo;
        }

        public List<Vivencia19TardeAPI.Models.TbAnoLetivo> ListarTodos()
        {
            List<Models.TbAnoLetivo> ano = db.TbAnoLetivo.OrderBy(t=> t.NrAno).ToList();
            return ano;
        }

         public bool ConsultarAno(Models.TbAnoLetivo model)
        {
           bool existe =  db.TbAnoLetivo.Any(t=> t.NrAno == model.NrAno);
            return existe;
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
        public void ModuloADD(Models.TbModulo modulo)
        {
            db.TbModulo.Add(modulo);
            db.SaveChanges();
        }
        public List<Models.TbModulo> ModuloConsultar()
        {
            List<Models.TbModulo> lista = db.TbModulo.ToList();
            return lista;
        }
        public void ModuloRemover(int id)
        {
         Models.TbModulo anos = db.TbModulo.FirstOrDefault(x => x.IdAnoLetivo == id);

            db.Remove(anos);
            db.SaveChanges();
        }
        public void ModuloALterar(Models.TbModulo modulo)
        {
            modulo.NmModulo = modulo.NmModulo;
            modulo.NrModulo = modulo.NrModulo;
            modulo.DtFinal = modulo.DtFinal;
            modulo.DtInicio = modulo.DtInicio;
            modulo.BtAberto = modulo.BtAberto;
        }

        public Models.TbAnoLetivo ConsultarAnoLetivo(int id)
        {
            return db.TbAnoLetivo.First(x => x.IdAnoLetivo == id);
        }
    }
}
