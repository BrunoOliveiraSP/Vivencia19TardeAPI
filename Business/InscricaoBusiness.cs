using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Vivencia19TardeAPI.Business
{
    public class InscricaoBusiness
    {
        Database.InscricaoDatabase db = new Database.InscricaoDatabase();
        public void Inserir(Models.TbInscricao inscricao )
        {
           
            bool rg = db.ExisteRG(inscricao.DsRg, inscricao.IdAnoLetivo);
            bool cpf = db.ExisteCpf(inscricao.DsCpf, inscricao.IdAnoLetivo);
            //boo l cpfValido = StringExtension.IsValidCep(inscricao.DsCpf);
            bool candidato = db.ExisteCandidato(inscricao.NmInscrito, inscricao.IdAnoLetivo);
            bool codigo = db.ExisteCodigoInscrição(inscricao.CdInscricao, inscricao.IdAnoLetivo);
            //bool tel1ResponsavelValido = StringExtension.IsValidPhone(inscricao.DsResponsavelTelefone);
            //bool tel2ResponsavelValido = StringExtension.IsValidPhone(inscricao.DsResponsavelTelefone2);
            //bool tel1Valido = StringExtension.IsValidPhone(inscricao.DsTelefone.Replace("(", "").Replace(")", "").Replace("-", ""));
            //bool tel2Valido = StringExtension.IsValidPhone(inscricao.DsTelefone2.Replace("(", "").Replace(")", "").Replace("-", ""));
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Informe o nome do candidato!"); 
            }
            if(candidato == true)
            {
                throw new ArgumentException("Esse candidato já foi cadastrado esse ano.");
            }
            DateTime dt = new DateTime(2005, 12, 12, 0, 0, 0);
            if(inscricao.DtNascimento > dt.Date)
            {
                throw new ArgumentException("Data de nascimento menor que 15 anos.");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo) || inscricao.DsSexo == "Selecione")
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
       
            //if(tel1Valido == false)
            //{
            //    throw new ArgumentException("Telefone 1 do candidato é inválido.");
            //}
            //if(tel2Valido == false)
            //{
             //   throw new ArgumentException("Telefone 2 do candidato é inválido.");
            //}
            //if(tel1ResponsavelValido == false)
            //{
             //   throw new ArgumentException("Telefone 1 do responsável é inválido.");
            //}
            //if(tel2ResponsavelValido == false)
            //{
             //   throw new ArgumentException("Telefone 2 do responsável é inválido.");
            //}
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o cpf do candidato!");
            }
            if(cpf == true)
            {
                throw new ArgumentException("Cpf já está em uso.");
            }
            //if(cpfValido == false)
            //{
             //   throw new ArgumentException("Cpf inválido.");
            //}
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de informar a cor da pele do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de informar o rg do candidato!");
            }
            if(rg == true)
            {
                throw new ArgumentException("Rg em uso.");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de informar o Orgão!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de informar o e-mail do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de informar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de informar o CEP de onde mora o funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
               throw new ArgumentException("Você esqueceu de informar o enderço do candidato!");
            }
            if (inscricao.NrResidenciaEndereco == 0)
            {
                throw new ArgumentException ("Você esqueceu de informar o numero da residencial do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaBairro))
            {
                throw new ArgumentException("Você esqueceu de informar o bairro do candidato! ");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
                throw new ArgumentException("Você esqueceu de informar o estado do candidato!");
            }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoEstado) || inscricao.DsNascimentoEstado == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar o estado em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoCidade))
           {
               throw new ArgumentException("Você esqueceu de informar a cidade em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoPais))
           {
               throw new ArgumentException("Você esqueceu de informar o país de nascimento do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de informar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 1 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 2 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de informar o e-mail do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de informar o nome do contato do responsável!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 2 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de informar o email do segundo candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelParentesco) || inscricao.DsResponsavelParentesco == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar o parentesco do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsEscolaridade) || inscricao.DsEscolaridade == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar a escolaridade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmEscola))
           {
               throw new ArgumentException("Você esqueceu de informar o nome da escola do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsCursoPeriodo))
           {
               throw new ArgumentException("Você esqueceu de informar o periodo do primeiro curso escolhido pelo candidato!");
           } 
           if (string.IsNullOrWhiteSpace(inscricao.DsCurso2Periodo))
           {
               throw new ArgumentException("Você esqueceu de informar o periodo do segundo curso escolhido pelo o candidato");
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
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Informe o nome do candidato!"); 
            }
            DateTime dt = new DateTime(2005, 12, 12, 0, 0, 0);
            if(inscricao.DtNascimento > dt.Date)
            {
                throw new ArgumentException("Data de nascimento menor que 15 anos.");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo) || inscricao.DsSexo == "Selecione")
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de colocar o cpf do candidato!");
            }
            if(string.IsNullOrWhiteSpace(inscricao.DsCorPele))
            {
                throw new ArgumentException("Você esqueceu de informar a cor da pele do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsRg.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de informar o rg do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsOrgao))
            {
                throw new ArgumentException("Você esqueceu de informar o Orgão!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsEmail))
            {
                throw new ArgumentException("Você esqueceu de informar o e-mail do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCidade))
            {
                throw new ArgumentException("Você esqueceu de informar a cidade onde mora o candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaCep.Replace("-", "").Replace("-", "")))
            {
                throw new ArgumentException("Você esqueceu de informar o CEP de onde mora o funcionario!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
               throw new ArgumentException("Você esqueceu de informar o enderço do candidato!");
            }
            if (inscricao.NrResidenciaEndereco == 0)
            {
                throw new ArgumentException ("Você esqueceu de informar o numero da residencial do candidato!");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaBairro))
            {
                throw new ArgumentException("Você esqueceu de informar o bairro do candidato! ");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsResidenciaEndereco))
            {
                throw new ArgumentException("Você esqueceu de informar o estado do candidato!");
            }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoEstado) || inscricao.DsNascimentoEstado == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar o estado em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoCidade))
           {
               throw new ArgumentException("Você esqueceu de informar a cidade em que nasceu o candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsNascimentoPais))
           {
               throw new ArgumentException("Você esqueceu de informar o país de nascimento do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelNome))
           {
               throw new ArgumentException("Você esqueceu de informar o nome do responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 1 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 2 do responsável do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de informar o e-mail do Responsavel do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmContato))
           {
               throw new ArgumentException("Você esqueceu de informar o nome do contato do responsável!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 1 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsTelefone2.Replace("(", "").Replace(")", "").Replace("-", "")))
           {
               throw new ArgumentException("Você esqueceu de informar o telefone 2 do segundo responsavel!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelEmail))
           {
               throw new ArgumentException("Você esqueceu de informar o email do segundo candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsResponsavelParentesco) || inscricao.DsResponsavelParentesco == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar o parentesco do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsEscolaridade) || inscricao.DsEscolaridade == "Selecione")
           {
               throw new ArgumentException("Você esqueceu de informar a escolaridade do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.NmEscola))
           {
               throw new ArgumentException("Você esqueceu de informar o nome da escola do candidato!");
           }
           if (string.IsNullOrWhiteSpace(inscricao.DsCursoPeriodo))
           {
               throw new ArgumentException("Você esqueceu de informar o periodo do primeiro curso escolhido pelo candidato!");
           } 
           if (string.IsNullOrWhiteSpace(inscricao.DsCurso2Periodo))
           {
               throw new ArgumentException("Você esqueceu de informar o periodo do segundo curso escolhido pelo o candidato");
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

           db.Alterar(inscricao);
        }
        public List<Models.InscricaoResponse> ConsultarTodos()
        {
            List<Models.TbInscricao> listaInscricao = db.ConsultarTodos();

            List<Models.InscricaoResponse> response = new List<Models.InscricaoResponse>();

            foreach(Models.TbInscricao inscricao in listaInscricao)
            {
                Models.InscricaoResponse r = CriarResponse(inscricao);
                response.Add(r);
            }
            return response;
        }
        public List<Models.InscricaoResponse> ConsultarPorNomeEAno(string nome, int ano)
        {
            if(nome == null)
            {
                nome = string.Empty;
            }
            if(ano == 0)
            {
                throw new ArgumentException("Informe o ano letivo.");
            }
            List<Models.TbInscricao> listaInscricao = db.ConsultarPorNomeEAno(nome, ano);

            List<Models.InscricaoResponse> response = new List<Models.InscricaoResponse>();

            foreach(Models.TbInscricao inscricao in listaInscricao)
            {
                Models.InscricaoResponse r = CriarResponse(inscricao);
                response.Add(r);
            }
            return response;
        }
        private Models.InscricaoResponse CriarResponse(Models.TbInscricao inscrito)
        {
            Models.InscricaoResponse response = new Models.InscricaoResponse();
            response.IdInscricao = inscrito.IdInscricao;
            response.IdSalaVestibular = inscrito.IdSalaVestibular;
            response.NmContato = inscrito.NmContato;
            response.NmEscola = inscrito.NmEscola;
            response.NmInscrito = inscrito.NmInscrito;
            response.NrResidenciaEndereco = inscrito.NrResidenciaEndereco;
            response.QtMoramCasa = inscrito.QtMoramCasa;
            response.QtTrabalhamCasa = inscrito.QtTrabalhamCasa;
            response.TpEscola = inscrito.TpEscola;
            response.VlNota = inscrito.VlNota;
            response.VlRenda = inscrito.VlRenda;
            response.BtMatriculado = inscrito.BtMatriculado;
            response.BtPendenteComprovresid = inscrito.BtPendenteComprovresid;
            response.BtPendenteCpf = inscrito.BtPendenteCpf;
            response.BtPendenteEscolaridade = inscrito.BtPendenteEscolaridade;
            response.BtPendentePagamento = inscrito.BtPendentePagamento;
            response.BtPendenteRg = inscrito.BtPendenteRg;
            response.CdInscricao = inscrito.CdInscricao;
            response.DsComoConheceu = inscrito.DsComoConheceu;
            response.DsCorPele = inscrito.DsCorPele;
            response.DsCpf = inscrito.DsCpf;
            response.DsCurso2Periodo = inscrito.DsCurso2Periodo;
            response.DsCursoPeriodo = inscrito.DsCursoPeriodo;
            response.DsEmail = inscrito.DsEmail;
            response.DsEmailInscrito = inscrito.DsEmailInscrito;
            response.DsEscolaridade = inscrito.DsEscolaridade;
            response.DsNascimentoCidade = inscrito.DsNascimentoCidade;
            response.DsNascimentoEstado = inscrito.DsNascimentoEstado;
            response.DsNascimentoPais = inscrito.DsNascimentoPais;
            response.DsObservacao = inscrito.DsObservacao;
            response.DsOrgao = inscrito.DsOrgao;
            response.DsResidenciaBairro = inscrito.DsResidenciaBairro;
            response.DsResidenciaCep = inscrito.DsResidenciaCep;
            response.DsResidenciaCidade = inscrito.DsResidenciaCidade;
            response.DsResidenciaComplelemento = inscrito.DsResidenciaComplelemento;
            response.DsResidenciaEndereco = inscrito.DsResidenciaEndereco;
            response.DsResidenciaEstado = inscrito.DsResidenciaEstado;
            response.DsResponsavelCpf = inscrito.DsResponsavelCpf;
            response.DsResponsavelEmail = inscrito.DsResponsavelEmail;
            response.DsResponsavelNome = inscrito.DsResponsavelNome;
            response.DsResponsavelParentesco = inscrito.DsResponsavelParentesco;
            response.DsResponsavelRg = inscrito.DsResponsavelRg;
            response.DsResponsavelTelefone = inscrito.DsResponsavelTelefone;
            response.DsResponsavelTelefone2 = inscrito.DsResponsavelTelefone2;
            response.DsRg = inscrito.DsRg;
            response.DsSexo = inscrito.DsSexo;
            response.DsSituacao = inscrito.DsSituacao;
            response.DsTelefone = inscrito.DsTelefone;
            response.DsTelefone2 = inscrito.DsTelefone2;
            response.DtEmissao = inscrito.DtEmissao;
            response.DtInclusao = inscrito.DtInclusao;
            response.DtNascimento = inscrito.DtNascimento;
            response.DtUltimaAlteracao = inscrito.DtUltimaAlteracao;
            response.IdAnoLetivo = inscrito.IdAnoLetivo;
            response.IdCurso = inscrito.IdCurso;
            response.IdCurso2 = inscrito.IdCurso2;
            response.IdFuncionarioAlteracao = inscrito.IdFuncionarioAlteracao;

            if(inscrito.IdCursoNavigation.IdCurso > 0)
            {
                response.NmCurso = inscrito.IdCursoNavigation.NmCurso;
            }

            if(inscrito.IdSalaVestibularNavigation.IdSalaVestibular > 0)
            {
                response.NmSala = inscrito.IdSalaVestibularNavigation.IdSalaNavigation.NmSala;
                response.NmLocal = inscrito.IdSalaVestibularNavigation.IdSalaNavigation.NmLocal;
                response.DsPeriodo = inscrito.IdSalaVestibularNavigation.DsPeriodo;
            }

            return response;
        }
        public List<Models.InscricaoResponse> ConsultarAnoLetivoLista(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Informe o ano letivo.");
            }
            List<Models.TbInscricao> listaInscricao = db.ConsultarPorAno(id);

            List<Models.InscricaoResponse> response = new List<Models.InscricaoResponse>();

            foreach(Models.TbInscricao inscricao in listaInscricao)
            {
                Models.InscricaoResponse r = CriarResponse(inscricao);
                response.Add(r);
            }
            
            return response;
        }
    }
}
    public static class StringExtension
	{
		public static bool IsValidEmail(this string email)
		{
			try
			{
				MailAddress m = new MailAddress(email);
				return true;
			}
			catch (Exception)
			{
				return false;
			}

            
		}

		public static bool IsValidPhone(this string phone)
		{
			var regex = new Regex(@"(?:^\(\d{2}\)\s)[9]?[1-9]\d{3}[-]\d{4}$", RegexOptions.Compiled);
			return regex.IsMatch(phone);
		}

		public static bool IsValidCpf(this string cpf)
		{
			var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", RegexOptions.Compiled);
			return regex.IsMatch(cpf);
		}

        public static bool IsValidCep(this string cep)
		{
			var regex = new Regex(@"^\d{5}-\d{3}$", RegexOptions.Compiled);
			return regex.IsMatch(cep);
		}

		public static string Numberfy(this string number)
		{
			string pattern = @"\d";

			var sb = new StringBuilder();

			foreach (var match in Regex.Matches(number, pattern))
				sb.Append(match);

			return sb.ToString();
		}

		public static string RemoveSpecial(this string s)
		{
			var sb = new StringBuilder();
			sb.Append(s.ToUpper().Trim());

			sb.Replace(".", string.Empty);

			sb.Replace(".", string.Empty);
			sb.Replace(",", string.Empty);
			sb.Replace(":", string.Empty);
			sb.Replace("*", string.Empty);
			sb.Replace("-", string.Empty);

			return sb.ToString();
		}
	}


