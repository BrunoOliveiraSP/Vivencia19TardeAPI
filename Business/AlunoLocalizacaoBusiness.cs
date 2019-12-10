using System.Collections.Generic;
using Vivencia19TardeAPI.Models;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoLocalizacaoBusiness
    {
        Database.AlunoLocalizacaoDatabase db = new Database.AlunoLocalizacaoDatabase();

        public void Inserir(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {

           db.Inserir(ModelAlunoLocalizacao);
        }
        public List<Models.TbAlunoLocalizacao> Consultar()
        {
           List<Models.TbAlunoLocalizacao> lista = db.Consultar();
           return lista;
        }
        public void Alterar(TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
         

           db.Alterar(ModelAlunoLocalizacao);
        }
        public void Deletar(int id)
        {
           db.Deletar(id);
        }

       
    }
}