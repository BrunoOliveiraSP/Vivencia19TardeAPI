using System.Collections.Generic;
using Vivencia19TardeAPI.Models;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class TbAlunoLocalizacaoBusiness
    {
        Database.TbAlunoLocalizacaoDatabase dt = new Database.TbAlunoLocalizacaoDatabase();

        public void Inserir(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
        if(ModelAlunoLocalizacao.DsNascimentoCidade == string.Empty)
           {
                throw new ArgumentException(" é obrigatório");
           }

            dt.Inserir(ModelAlunoLocalizacao);
        }
        public List<Models.TbAlunoLocalizacao> Consultar()
        {
           List<Models.TbAlunoLocalizacao> lista =dt.Consultar();
           return lista;
        }
        public void Alterar(int id,TbAlunoLocalizacao local)
        {





            
            dt.Alterar(id,local);
        }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        } 

    }
}