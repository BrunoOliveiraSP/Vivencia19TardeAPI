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
                throw new ArgumentException("Cidade de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsNascimentoEstado == string.Empty)
           {
                throw new ArgumentException("Estado de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsNascimentoPais == string.Empty)
           {
                throw new ArgumentException("País de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaBairro == string.Empty)
           {
                throw new ArgumentException("Bairro atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaCep == string.Empty)
           {
                throw new ArgumentException("Cep atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaCidade == string.Empty)
           {
                throw new ArgumentException("Cidade atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaEndereco == string.Empty)
           {
                throw new ArgumentException("Endereço atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaEstado == string.Empty)
           {
                throw new ArgumentException("Estado atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.NrResidenciaEndereco == 0)
           {
                throw new ArgumentException("Número da casa é obrigatório");
           }

            dt.Inserir(ModelAlunoLocalizacao);
        }
        public List<Models.TbAlunoLocalizacao> Consultar()
        {
           List<Models.TbAlunoLocalizacao> lista = dt.Consultar();
           return lista;
        }
        public void Alterar(int id,TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
            if(ModelAlunoLocalizacao.DsNascimentoCidade == string.Empty)
           {
                throw new ArgumentException("Cidade de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsNascimentoEstado == string.Empty)
           {
                throw new ArgumentException("Estado de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsNascimentoPais == string.Empty)
           {
                throw new ArgumentException("País de nascimento é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaBairro == string.Empty)
           {
                throw new ArgumentException("Bairro atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaCep == string.Empty)
           {
                throw new ArgumentException("Cep atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaCidade == string.Empty)
           {
                throw new ArgumentException("Cidade atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaEndereco == string.Empty)
           {
                throw new ArgumentException("Endereço atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.DsResidenciaEstado == string.Empty)
           {
                throw new ArgumentException("Estado atual é obrigatório");
           }

           if(ModelAlunoLocalizacao.NrResidenciaEndereco == 0)
           {
                throw new ArgumentException("Número da casa é obrigatório");
           }

            dt.Alterar(id, ModelAlunoLocalizacao);
        }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        } 
    }
}