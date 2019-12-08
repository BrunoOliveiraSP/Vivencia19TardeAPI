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

         
        public void Alterar(Models.TbAnoLetivo anoLetivo)
        {
            if(anoLetivo.IdAnoLetivo == 0)
            throw new ArgumentException("ID Inválido");

            if(anoLetivo.NrAno == 0)
            throw new ArgumentException("Ano Obrigatório");

            if(anoLetivo.DtFim <= anoLetivo.DtInicio)
            throw new ArgumentException("Data Final Inválida");

            if(anoLetivo.TpStatus == string.Empty)
            throw new ArgumentException("Status Obrigatório");

            db.Alterar(anoLetivo);
        }
        public void Remover (int id)
        {
            if(id == 0)
            throw new ArgumentException("ID Inválido");

            db.Remover(id);
        }
        public void InserirModulo(Models.TbModulo modulo)
        {
            if(modulo.NmModulo == null)
            throw new ArgumentException("Modulo Invalido");

            if(modulo.NrModulo >= 0)
            throw new ArgumentException("Numero Invalido");

            if(modulo.DtInicio == null || modulo.DtFinal == null)
             throw new ArgumentException("Datas Invalidas Invalido");
             
                      
        }
       // public List<Models.TbModulo> ConsultarModulo()
       // {
        // List<Models.TbModulo> lista = db.ModuloConsultar();
         //return lista;
       // }
        public void AlterarModulo(Models.TbModulo modulo)
        {
           db.ModuloALterar(modulo);
        }
        public void RemoverModulo (int id)
        {
           db.ModuloRemover(id);
        }
    }
}