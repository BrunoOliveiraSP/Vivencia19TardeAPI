using System.Collections.Generic;
using System;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoMensalidadeBusiness
    {
        Database.AlunoMensalidadeDatabase dt = new Database.AlunoMensalidadeDatabase();
       public void Inserir(Models.TbAlunoMensalidade Mensalidade)
       {
           dt.Inserir(Mensalidade);

       }

       public List<Models.TbAlunoMensalidade> ListarTodos ()
       {
           return dt.ListarTodos();
       }

       public void alterar (Models.TbAlunoMensalidade mensalidade)
       {
           dt.alterar(mensalidade);
       }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        }

        public void validacao(Models.TbAlunoMensalidade mensalidade)
        {

        }
    }
}