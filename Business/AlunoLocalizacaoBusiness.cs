using System.Collections.Generic;
using Vivencia19TardeAPI.Models;
using System;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoLocalizacaoBusiness
    {
        Database.AlunoLocalizacaoDatabase dt = new Database.AlunoLocalizacaoDatabase();

        public void Inserir(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
           this.Validacao(ModelAlunoLocalizacao);

           dt.Inserir(ModelAlunoLocalizacao);
        }
        public List<Models.TbAlunoLocalizacao> Consultar()
        {
           List<Models.TbAlunoLocalizacao> lista = dt.Consultar();
           return lista;
        }
        public void Alterar(TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
           this.Validacao(ModelAlunoLocalizacao);

           dt.Alterar(ModelAlunoLocalizacao);
        }
        public void Deletar(int id)
        {
           dt.Deletar(id);
        }

        public void Validacao(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
           if(ModelAlunoLocalizacao.DsNascimentoCidade == string.Empty)
           {
                throw new ArgumentException("Cidade de nascimento é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsNascimentoEstado == string.Empty)
           {
                throw new ArgumentException("Estado de nascimento é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsNascimentoPais == string.Empty)
           {
                throw new ArgumentException("País de nascimento é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsResidenciaBairro == string.Empty)
           {
                throw new ArgumentException("Bairro atual é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsResidenciaCep == string.Empty)
           {
                throw new ArgumentException("Cep atual é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsResidenciaCidade == string.Empty)
           {
                throw new ArgumentException("Cidade atual é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsResidenciaEndereco == string.Empty)
           {
                throw new ArgumentException("Endereço atual é obrigatório");
           }

           else if(ModelAlunoLocalizacao.DsResidenciaEstado == string.Empty)
           {
                throw new ArgumentException("Estado atual é obrigatório");
           }

           else if(ModelAlunoLocalizacao.NrResidenciaEndereco == 0)
           {
                throw new ArgumentException("Número da casa é obrigatório");
           }


        }
    }
}