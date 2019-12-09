using System.Collections.Generic;
using Vivencia19TardeAPI.Models;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoLocalizacaoBusiness
    {
        Database.AlunoLocalizacaoDatabase dt = new Database.AlunoLocalizacaoDatabase();

        public void Inserir(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {

           dt.Inserir(ModelAlunoLocalizacao);
        }
        public List<Models.TbAlunoLocalizacao> Consultar()
        {
           List<Models.TbAlunoLocalizacao> lista = dt.Consultar();
           return lista;
        }
        public void Alterar(TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
         

           dt.Alterar(ModelAlunoLocalizacao);
        }
        public void Deletar(int id)
        {
           dt.Deletar(id);
        }

       
    }
}