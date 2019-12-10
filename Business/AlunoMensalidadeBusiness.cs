using System.Collections.Generic;
using System;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoMensalidadeBusiness
    {
        Database.AlunoMensalidadeDatabase db = new Database.AlunoMensalidadeDatabase();
       public void Inserir(Models.TbAlunoMensalidade Mensalidade)
       {
           db.Inserir(Mensalidade);
       }

       public List<Models.TbAlunoMensalidade> ListarTodos ()
       {
           return db.ListarTodos();
       }

       public void alterar (Models.TbAlunoMensalidade mensalidade)
       {
        
           db.alterar(mensalidade);
       }
        public void Deletar(int id)
        {
            db.Deletar(id);
        }

        
    }
}