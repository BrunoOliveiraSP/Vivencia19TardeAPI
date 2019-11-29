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
       
         public void remover(int id)
        {
            Models.TbSala remove = md.TbSala.First(x=> x.IdSala == id);
            md.TbSala.Remove(remove);
            md.SaveChanges();
        }
        public void alterar (Models.TbSala tabela)
        {
            Models.TbSala alterar = md.TbSala.First(x=> x.IdSala == tabela.IdSala);
            alterar.NmLocal = tabela.NmLocal;
            alterar.NmSala = tabela.NmSala;
            alterar.NrCapacidadeMaxima = tabela.NrCapacidadeMaxima;
            alterar.TbSalaVestibular = tabela.TbSalaVestibular;
            alterar.DtInclusao = tabela.DtInclusao;
            alterar.DtAlteracao = tabela.DtAlteracao;
            alterar.BtAtivo = tabela.BtAtivo;
            md.SaveChanges();
        }
        public List<Models.TbSala> ConsultarPorInstituicao(string instituicao)
        {            
            List<Models.TbSala> consulta = md.TbSala.Where(x => x.NmLocal.Contains(instituicao)).ToList();
            return consulta;
        }



    }
}