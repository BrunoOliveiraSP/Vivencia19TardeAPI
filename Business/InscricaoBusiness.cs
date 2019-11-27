using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;  

namespace Vivencia19TardeAPI.Business
{
    public class InscricaoBusiness
    {
        Database.InscricaoDatabase db = new Database.InscricaoDatabase();

        public void Inserir(Models.TbInscricao inscricao )
        {
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Você esqueceu de colocar o nome do concorrente!"); 
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo))
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf))
            {
                throw new ArgumentException("Você esqueceu de colocar o CPF do candidato!");
            }
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de colocar a etnia do CPF do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg))
            {
                throw new ArgumentException("Você esqueceu de colocar o RG do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de colocar o Orgão do RG do funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de colocar o Email do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de colocar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep))
            {
                throw new ArgumentException("Você esqueceu de colocar o CEP de onde mra o funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
               throw new ArgumentException("Você esqueceu de colocar o enderço do candidato!");
            }
            if (inscricao.NrResidenciaEndereco == 0)
            {
                throw new ArgumentException ("Você esqueceu de colocar o numero da residencial do candidato");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaBairro))
            {
                throw new ArgumentException("Você esqueceu de colocar o Bairro do candidato ");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
                throw new ArgumentException("Você esqueceu de colocar o estado do candidato!");
            }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoEstado))
           {
               throw new ArgumentException("Você esqueceu de colocar o estado em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoCidade))
           {
               throw new ArgumentException("Você esqueceu de colocar a Cidade em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoPais))
           {
               throw new ArgumentException("Você esqueceu de colocar a Nacionalidade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 1 do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 2 do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o Email do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de colocar o Nome do contato do funcionario!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 2 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o email do segundo candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelParentesco))
           {
               throw new ArgumentException("Você esqueceu de colocar o parentesco do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsEscolaridade))
           {
               throw new ArgumentException("Você esqueceu de colocar a escolaridade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmEscola))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome da escola do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsCursoPeriodo))
           {
               throw new ArgumentException("Você esqueceu de colocar o periodo do primeiro curso escolhido pelo candidato!");
           } 
           if (string.IsNullOrWhiteSpace(inscricao.DsCurso2Periodo))
           {
               throw new ArgumentException("Você esqueceu de colocar o periodo do segundo curso escolhido pelo o candidato");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsComoConheceu))
           {
               throw new ArgumentException("Você esqueceu de colocar como o candidato conheceu o Instituto!");
           }
           if (inscricao.VlRenda == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar a renda media do candidato!");
           }
           if (inscricao.QtMoramCasa == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar quantas pessoas moram na casa do candidato!");
           }

            db.Inserir(inscricao);
        }

        public void Remover(int id)
        {
            if(id == 0)
            {
                throw new ArgumentException("Informe o registro que deseja deletar!");
            }
            db.Remover(id);
        }

        public void Alterar(Models.TbInscricao inscricao)
        {
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Você esqueceu de colocar o nome do concorrente!"); 
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo))
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf))
            {
                throw new ArgumentException("Você esqueceu de colocar o CPF do candidato!");
            }
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de colocar a etnia do CPF do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg))
            {
                throw new ArgumentException("Você esqueceu de colocar o RG do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de colocar o Orgão do RG do funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de colocar o Email do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de colocar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep))
            {
                throw new ArgumentException("Você esqueceu de colocar o CEP de onde mra o funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
               throw new ArgumentException("Você esqueceu de colocar o enderço do candidato!");
            }
            if (inscricao.NrResidenciaEndereco == 0)
            {
                throw new ArgumentException ("Você esqueceu de colocar o numero da residencial do candidato");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaBairro))
            {
                throw new ArgumentException("Você esqueceu de colocar o Bairro do candidato ");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
                throw new ArgumentException("Você esqueceu de colocar o estado do candidato!");
            }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoEstado))
           {
               throw new ArgumentException("Você esqueceu de colocar o estado em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoCidade))
           {
               throw new ArgumentException("Você esqueceu de colocar a Cidade em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoPais))
           {
               throw new ArgumentException("Você esqueceu de colocar a Nacionalidade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 1 do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 2 do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o Email do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de colocar o Nome do contato do funcionario!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 2 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o email do segundo candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelParentesco))
           {
               throw new ArgumentException("Você esqueceu de colocar o parentesco do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsEscolaridade))
           {
               throw new ArgumentException("Você esqueceu de colocar a escolaridade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmEscola))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome da escola do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsCursoPeriodo))
           {
               throw new ArgumentException("Você esqueceu de colocar o periodo do primeiro curso escolhido pelo candidato!");
           } 
           if (string.IsNullOrWhiteSpace(inscricao.DsCurso2Periodo))
           {
               throw new ArgumentException("Você esqueceu de colocar o periodo do segundo curso escolhido pelo o candidato");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsComoConheceu))
           {
               throw new ArgumentException("Você esqueceu de colocar como o candidato conheceu o Instituto!");
           }
           if (inscricao.VlRenda == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar a renda media do candidato!");
           }
           if (inscricao.QtMoramCasa == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar quantas pessoas moram na casa do candidato!");
           }

            db.Alterar(inscricao);
        }

        public List<Models.TbInscricao> ConsultarTodos()
        {
            return db.ConsultarTodos();
        }

        //Direciona para sua respectiva função a partir da função abaixo
        public List<Models.TbInscricao> ConsultarPorNomeEAno(string nome, int ano)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
              return db.ConsultarPorAno(ano);
            }
            else if(ano == 0000 || ano == null)
            {
              return db.ConsultarPorNome(nome); 
            }
            else
            {
              return db.ConsultarPorNomeEAno(nome, ano);
            }
        }
    }
}