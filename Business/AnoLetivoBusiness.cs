using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class AnoLetivoBusiness
    {
        Database.AnoLetivoDatabase db = new Database.AnoLetivoDatabase();
        public void Inserir(Models.TbAnoLetivo ano)
        {  
         if(ano.NrAno == 0)
         throw new ArgumentException ("O ano não pode ser zero!");

         if(ano.TpStatus == "")
         throw new ArgumentException("O status não pode ser vazio!");

         if(ano.DtInicio == null || ano.DtFim == null)
         throw new ArgumentException("Data inválida!");
         
         db.CadastrarAnoLetivo(ano);
        }

        public List<Models.TbAnoLetivo> ListarTodos()
        {
            List<Models.TbAnoLetivo> lista = db.ListarTodos();
            return lista;
        }
        public void Alterar(Models.TbAnoLetivo ano)
        {
            db.Alterar(ano);
        }
        public void Remover (int id)
        {
            db.Remover(id);
        }
    }
}