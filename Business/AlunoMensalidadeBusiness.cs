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
           this.Validacao(Mensalidade);

           dt.Inserir(Mensalidade);
       }

       public List<Models.TbAlunoMensalidade> ListarTodos ()
       {
           return dt.ListarTodos();
       }

       public void alterar (Models.TbAlunoMensalidade mensalidade)
       {
           this.Validacao(mensalidade);
        
           dt.alterar(mensalidade);
       }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        }

        public void Validacao(Models.TbAlunoMensalidade ModelAlunoMensalidade)
        {
            if(ModelAlunoMensalidade.DsMesref == string.Empty)
            {
                throw new Exception("Mesref é obrigatório");
            }
            else if(ModelAlunoMensalidade.DsObservacao == string.Empty)
            {
                throw new Exception("Observação é obrigatório");
            }
            else if(ModelAlunoMensalidade.NrFolhaCarne == string.Empty)
            {
                throw new Exception("Número de Folhas do Carne é obrigatório");
            }
            else if(ModelAlunoMensalidade.TpPagamento == string.Empty)
            {
                throw new Exception("Tipo de pagamento é obrigatório");
            }
            else if(ModelAlunoMensalidade.NrOrdem == 0)
            {
                throw new Exception("Número ordem é obrigatório");
            }
            else if(ModelAlunoMensalidade.VlMensalidade == 0)
            {
                throw new Exception("Valor da mensalidade é obrigatório");
            }
            else if(ModelAlunoMensalidade.NrParcela == 0)
            {
                throw new Exception("Número de parcelas é obrigatório");
            }
        }
    }
}