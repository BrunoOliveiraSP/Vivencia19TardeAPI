using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

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
            List<Models.TbSalaVestibular> sala = md.TbSalaVestibular.ToList();
            
            return sala;
        }
       
         public void Remover(int id)
        {
            Models.TbSalaVestibular remove = md.TbSalaVestibular.First(x=> x.IdSala == id);
            md.TbSalaVestibular.Remove(remove);
            md.SaveChanges();
        }
        public void Alterar (Models.TbSalaVestibular tabela)
        {
            Models.TbSalaVestibular alterar = md.TbSalaVestibular.First(x=> x.IdSala == tabela.IdSala);
            alterar.DsPeriodo = tabela.DsPeriodo;
            alterar.IdSala = tabela.IdSala;
            alterar.NrOrdem = tabela.NrOrdem;
            alterar.QtInscritos = tabela.QtInscritos;
            md.SaveChanges();
        }
    }
}