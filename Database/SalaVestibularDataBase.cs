using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Vivencia19TardeAPI.Database
{
    public class SalaVestibularDataBase
    {
         Models.db_a5064d_freiContext md = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbSalaVestibular sala)
        {
            md.TbSalaVestibular.Add(sala);
            md.SaveChanges();
        }
        public List<Models.TbSalaVestibular> Listar()
        {
            return md.TbSalaVestibular.Include(x => x.IdSalaNavigation)
                                      .ToList();                   
        }
       
         public void Remover(int id)
        {
            Models.TbSalaVestibular remove = md.TbSalaVestibular.First(x => x.IdSalaVestibular == id);
            md.TbSalaVestibular.Remove(remove);
            md.SaveChanges();
        }
        public void Alterar (Models.TbSalaVestibular tabela)
        {
            Models.TbSalaVestibular alterar = md.TbSalaVestibular.FirstOrDefault(x=> x.IdSala == tabela.IdSala);
            alterar.DsPeriodo = tabela.DsPeriodo;
            alterar.IdSalaNavigation.NmLocal = tabela.IdSalaNavigation.NmLocal;
            alterar.IdSalaNavigation.NmSala = tabela.IdSalaNavigation.NmSala;

            md.SaveChanges();
        }
    }
}