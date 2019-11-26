using System.Collections.Generic;
using System;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Business
{
    public class TbAlunoMensalidadeBusiness
    {
        Database.TbAlunoMensalidadeDatabase dt = new Database.TbAlunoMensalidadeDatabase();
       public void Inserir(Models.TbAlunoMensalidade Mensalidade)
       {
           if(Mensalidade.DsEmail.Contains("@") == false && Mensalidade.DsEmail.Contains(".com") == false && Mensalidade.DsEmail == string.Empty )
           {
                throw new ArgumentException("E-mail é obrigatório");
           }

           if(Mensalidade.DsParentesco == string.Empty)
           {
                throw new ArgumentException("Parentesco é obrigatório");
           }

           if(Mensalidade.DsRg == string.Empty)
           {
                throw new ArgumentException("RG é obrigatório");
           }

           if(Mensalidade.DsTelefone1 == string.Empty)
           {
                throw new ArgumentException("Telefone 1 é obrigatório");
           }
        
           if(Mensalidade.DsTelefone2 == string.Empty)
           {
                throw new ArgumentException("Telefone 2 é obrigatório");
           }

           if(Mensalidade.NmResponsavel == string.Empty)
           {
                throw new ArgumentException("Responsável é obrigatório");
           }

          dt.Inserir(Mensalidade);
       } 
       public List<Models.TbAlunoMensalidade> Consultar()
       {
          List<Models.TbAlunoMensalidade> lista = dt.Consultar();

          return lista;
       }
       public void Alterar(int id,TbAlunoMensalidade Mensalidade)
       {
            if(Mensalidade.DsEmail.Contains("@") == false && Mensalidade.DsEmail.Contains(".com") == false && Mensalidade.DsEmail == string.Empty )
           {
                throw new ArgumentException("E-mail é obrigatório");
           }

           if(Mensalidade.DsParentesco == string.Empty)
           {
                throw new ArgumentException("Parentesco é obrigatório");
           }

           if(Mensalidade.DsRg == string.Empty)
           {
                throw new ArgumentException("RG é obrigatório");
           }

           if(Mensalidade.DsTelefone1 == string.Empty)
           {
                throw new ArgumentException("Telefone 1 é obrigatório");
           }
        
           if(Mensalidade.DsTelefone2 == string.Empty)
           {
                throw new ArgumentException("Telefone 2 é obrigatório");
           }

           if(Mensalidade.NmResponsavel == string.Empty)
           {
                throw new ArgumentException("Responsável é obrigatório");
           }
           
           dt.Alterar(id, Mensalidade);
       }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        }
    }
}