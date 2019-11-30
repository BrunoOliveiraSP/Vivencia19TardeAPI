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
           

          
           
       }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        }
    }
}