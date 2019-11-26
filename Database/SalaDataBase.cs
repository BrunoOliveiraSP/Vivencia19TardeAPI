using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    public class SalaDataBase
    {
        Models.db_a5064d_freiContext md = new Models.db_a5064d_freiContext();
        public void inserir(Models.TbSala sala)
        {
            md.TbSala.Add(sala);
             md.SaveChanges();
        }
        public List<Models.TbSala> Listar()
        {
            List<Models.TbSala> filme = md.TbSala.ToList
            ();
            return filme;
        }
        public void remover(Models.TbSala tabela)
        {
            Models.TbSala remove = md.TbSala.First(x=> x.IdSala == tabela.IdSala);
            md.TbSala.Remove(remove);
            md.SaveChanges();
        }



    }
}