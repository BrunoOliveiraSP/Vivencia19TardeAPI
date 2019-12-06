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
            bool candidato = db.ExisteCandidato(inscricao.NmInscrito, inscricao.IdAnoLetivo);
            bool rg = db.ExisteRG(inscricao.DsRg);
            bool cpf = db.ExisteCpf(inscricao.DsCpf);
            bool codigo = db.ExisteCodigoInscrição(inscricao.CdInscricao);

            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Informe o nome do candidato!"); 
            }
            if(candidato == true)
            {
                throw new ArgumentException("Esse candidato já foi cadastrado esse ano.");
            }
            DateTime dt = new DateTime(2004, 01, 01, 0, 0, 0);
            if(inscricao.DtNascimento > dt.Date)
            {
                throw new ArgumentException("Data de nascimento inválida.");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo) || inscricao.DsSexo == "Selecione")
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o cpf do candidato!");
            }
            if(cpf == true)
            {
                throw new ArgumentException("Cpf já está em uso.");
            }
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de colocar a cor da pele do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o rg do candidato!");
            }
            if(rg == true)
            {
                throw new ArgumentException("Rg em uso.");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de colocar o Oorgão!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de colocar o e-mail do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de colocar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o CEP de onde mora o funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
               throw new ArgumentException("Você esqueceu de colocar o enderço do candidato!");
            }
            if (inscricao.NrResidenciaEndereco == 0)
            {
                throw new ArgumentException ("Você esqueceu de colocar o numero da residencial do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaBairro))
            {
                throw new ArgumentException("Você esqueceu de colocar o bairro do candidato! ");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
                throw new ArgumentException("Você esqueceu de colocar o estado do candidato!");
            }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoEstado) || inscricao.DsNascimentoEstado == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de colocar o estado em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoCidade))
           {
               throw new ArgumentException("Você esqueceu de colocar a cidade em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoPais))
           {
               throw new ArgumentException("Você esqueceu de colocar o país de nascimento do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 1 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 2 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o e-mail do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome do contato do responsável!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 2 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o email do segundo candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelParentesco) || inscricao.DsResponsavelParentesco == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de colocar o parentesco do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsEscolaridade) || inscricao.DsEscolaridade == "Selecione")
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
           if (string.IsNullOrWhiteSpace(inscricao.DsComoConheceu) || inscricao.DsComoConheceu == "Selecione" )
           {
               throw new ArgumentException("Você esqueceu de colocar como o candidato conheceu o instituto!");
           }
           if (inscricao.VlRenda == 0 || inscricao.VlRenda == 0.00m)
           {
               throw new ArgumentException("Você esqueceu de colocar a renda media do candidato!");
           }
           if (inscricao.QtMoramCasa == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar quantas pessoas moram na casa do candidato!");
           }
           if(inscricao.QtTrabalhamCasa == 0)
           {
               throw new ArgumentException("Informe a quantidade de pessoas que trabalham na casa");
           }
           if(string.IsNullOrWhiteSpace((inscricao.CdInscricao).ToString()) || inscricao.CdInscricao == 0)
           {
               throw new ArgumentException("Informe o código de inscrição");
           }
           if(codigo == true)
           {
               throw new ArgumentException("Código de inscrição já está em uso!");
           }
           if(inscricao.VlNota == 0 || inscricao.VlNota == 0.00m)
           {
               throw new ArgumentException("Nota inválida!");
           }
           if(string.IsNullOrWhiteSpace(inscricao.DsObservacao))
           {
               throw new ArgumentException("Informe uma observação!");
           }
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação!");
           }
           
           if(inscricao.IdSalaVestibular == 0)
           {
               throw new ArgumentException("Essa sala não existe!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResponsavelCpf.Replace("-", "").Replace("-", "")))
           {
               throw new ArgumentException("Informe um cpf!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResponsavelRg.Replace("-", "").Replace("-", "")))
           {
               throw new ArgumentException("Informe um rg!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsEmailInscrito) || inscricao.DsEmailInscrito.Contains("@") == false)
           {
               throw new ArgumentException("Informe o e-mail do inscrito!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.TpEscola))
           {
               throw new ArgumentException("Informe o tipo da escola do candidato!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResidenciaEstado) || inscricao.DsResidenciaEstado == "Selecione")
           {
               throw new ArgumentException("Informe o estado da residência!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResidenciaComplelemento))
           {
               throw new ArgumentException("Informe um complemento sobre a residencia!");
           }
           
           if(inscricao.IdCurso == 0)
           {
               throw new ArgumentException("Informe um curso!");
           }
           if(inscricao.IdCurso2 == 0)
           {
               throw new ArgumentException("Informe um curso como segunda opção!");
           }
           if(inscricao.IdAnoLetivo == 0)
           {
               throw new ArgumentException("Informe um ano letivo!");
           }
           if(inscricao.IdInscricao > 0)
           {
               throw new ArgumentException("Professor, sem id de inscrição em inserção!!!");
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
           //bool candidato = db.ExisteCandidato(inscricao.NmInscrito, inscricao.IdAnoLetivo);
           //bool rg = db.ExisteRG(inscricao.DsRg);
           // bool cpf = db.ExisteCpf(inscricao.DsCpf);
           // bool codigo = db.ExisteCodigoInscrição(inscricao.CdInscricao);
            
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Informe o nome do candidato!"); 
            }
            //if(candidato == true)
            //{
            //    throw new ArgumentException("Esse candidato já foi cadastrado esse ano");
            //}
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo))
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o CPF do candidato!");
            }
            //if(cpf == true)
           //     throw new ArgumentException("Cpf já está em uso");
           // }
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de colocar a cor da pele do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o RG do candidato!");
            }
            //if(rg == true)
           // {
           //     throw new ArgumentException("RG em uso");
           // }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de colocar o orgão!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de colocar o Email do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de colocar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o CEP de onde mora o funcionario!");
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
               throw new ArgumentException("Você esqueceu de colocar o País de nascimento do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de colocar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 1 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o Telefone 2 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de colocar o Email do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de colocar o Nome do contato do responsável!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de colocar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
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
           if (inscricao.VlRenda == 0 || inscricao.VlRenda == 0.00m)
           {
               throw new ArgumentException("Você esqueceu de colocar a renda media do candidato!");
           }
           if (inscricao.QtMoramCasa == 0)
           {
               throw new ArgumentException("Você esqueceu de colocar quantas pessoas moram na casa do candidato!");
           }
           if(inscricao.QtTrabalhamCasa == 0)
           {
               throw new ArgumentException("Informe a quantidade de pessoas que trabalham na casa");
           }
           if(string.IsNullOrWhiteSpace((inscricao.CdInscricao).ToString()) || inscricao.CdInscricao == 0)
           {
               throw new ArgumentException("Informe o código de inscrição");
           }
           //if(codigo == true)
           //{
           //    throw new ArgumentException("Código já está em uso");
           //}
           if(inscricao.VlNota == 0 || inscricao.VlNota == 0.00m)
           {
               throw new ArgumentException("Nota inválida");
           }
           if(string.IsNullOrWhiteSpace(inscricao.DsObservacao))
           {
               throw new ArgumentException("Informe uma observação");
           }
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação");
           }
           
           if(inscricao.IdSalaVestibular == 0)
           {
               throw new ArgumentException("Essa sala não existe!");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResponsavelCpf.Replace("-", "").Replace("-", "")))
           {
               throw new ArgumentException("Informe um Cpf");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResponsavelRg.Replace("-", "").Replace("-", "")))
           {
               throw new ArgumentException("Informe um RG");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsEmailInscrito) || inscricao.DsEmailInscrito.Contains("@") == false)
           {
               throw new ArgumentException("Informe o E-mail do inscrito");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsSituacao))
           {
               throw new ArgumentException("Informe uma situação");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.TpEscola))
           {
               throw new ArgumentException("Informe o tipo da escola do candidato");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResidenciaEstado))
           {
               throw new ArgumentException("Informe o Estado da Residência");
           }
           
           if(string.IsNullOrWhiteSpace(inscricao.DsResidenciaComplelemento))
           {
               throw new ArgumentException("Informe um Complemento sobre a residencia");
           }
           
           if(inscricao.IdCurso == 0)
           {
               throw new ArgumentException("Informe um curso");
           }
           if(inscricao.IdCurso2 == 0)
           {
               throw new ArgumentException("Informe um curso como segunda opção");
           }
           if(inscricao.IdAnoLetivo == 0)
           {
               throw new ArgumentException("Informe um ano letivo");
           }
           if(inscricao.IdInscricao == 0)
           {
               throw new ArgumentException("Professor, sem id 0 em alteração em inserção!!!");
           }
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
            else if(ano == 0000)
            {
              return db.ConsultarPorNome(nome); 
            }
            else
            {
              return db.ConsultarPorNomeEAno(nome, ano);
            }
        }

        public Models.TbAnoLetivo ConsultarAnoLetivo(int id)
        {
            if(id == 0)
               throw new ArgumentException("Informe o ano letivo");

            return db.ConsultarAnoLetivo(id);
        }

        public Models.TbCurso ConsultarCurso(int id)
        {
            if(id == 0)
               throw new ArgumentException("Informe o curso");

            return db.ConsultarCurso(id);   
        }
    }
}