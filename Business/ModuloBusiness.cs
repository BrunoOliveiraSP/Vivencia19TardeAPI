using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class ModuloBusiness
    {
      Database.ModuloDatabase db = new Database.ModuloDatabase();
        
        public void Inserir (Models.TbModulo modulo) 
        {
            if(modulo.TpModulo == string.Empty)
            throw new ArgumentException("Campo vazio.");            

            if(modulo.NmModulo == string.Empty)
            throw new ArgumentException("Campo vazio.");

            if(modulo.NrModulo <= 0)
            throw new ArgumentException("Valor inválido.");

            if(modulo.DtInicio == null || modulo.DtFinal == null)
            throw new ArgumentException("Data inválida!");

            db.Inserir(modulo);          
        }

        public List<Models.TbModulo> ConsultarTodos()
        {
            List<Models.TbModulo> lista = db.ConsultarTodos();
            return lista;
        }
        
      public void Alterar(Models.TbModulo modulo)
      {
          if(modulo.TpModulo == string.Empty)          {
              throw new Exception("O tipo do modulo não pode ser vazio");
          }
          if(modulo.NmModulo == string.Empty)
          {
              throw new Exception("O nome do modulo não pode ser vazio");
          }
          if(modulo.NrModulo <= 0)
          {
              throw new Exception("O numero maximo não pode ser 0");
          }
          if(modulo.DtInicio == null || modulo.DtFinal == null)
          {
              throw new Exception("As datas de início e/ou de final não podem estar vazias");
          }

          db.Alterar(modulo);
      }  

      public void Remover(int id)
      {
          db.Remover(id);
      }  
    }
}