using Vivencia19TardeAPI.Models;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
namespace Vivencia19TardeAPI.Business
{
    public class MatriculaBusiness
    {
        Database.AlunoTurmaDatabase TurmaAlunoDB = new Database.AlunoTurmaDatabase();
        Database.AlunoDatabase AlunoDB = new Database.AlunoDatabase();
        AlunoBusiness AlunoBusiness = new AlunoBusiness();
        AlunoDocumentosBusiness AlunoDocumentosBusiness = new AlunoDocumentosBusiness();

        AlunoFichaMedicaBusiness AlunoFichaMedicaBusiness = new AlunoFichaMedicaBusiness();

        AlunoLocalizacaoBusiness AlunoLocalizacaoBusiness = new AlunoLocalizacaoBusiness();
        AlunoMensalidadeBusiness AlunoMensalidadeBusiness = new AlunoMensalidadeBusiness();
        AlunoResponsavelBusiness AlunoResponsavelBusiness = new AlunoResponsavelBusiness();
        AlunoTurmaBusiness AlunoTurmaBusiness = new AlunoTurmaBusiness();
        AlunoCarometroBusiness AlunoCarometroBusiness = new AlunoCarometroBusiness();

        public void Inserir(MatriculaRequest request)
        {
            this.ValidacaoAluno(request.Aluno);
            this.ValidacaoCarometro(request.Carometro);
            this.ValidacaoMensalidade(request.Mensalidade);
            this.ValidacaoResponsavel(request.Responsavel);
            this.ValidarTurmaAluno(request.TurmaAluno);
            
            AlunoBusiness.inserir(request.Aluno);

            request.Documentos.IdAluno = request.Aluno.IdAluno;
            AlunoDocumentosBusiness.Inserir(request.Documentos);

            request.FichaMedica.IdAluno = request.Aluno.IdAluno;
            AlunoFichaMedicaBusiness.Inserir(request.FichaMedica);

            request.Localizacao.IdAluno = request.Aluno.IdAluno;
            AlunoLocalizacaoBusiness.Inserir(request.Localizacao);

            request.Mensalidade.IdAluno = request.Aluno.IdAluno;
            AlunoMensalidadeBusiness.Inserir(request.Mensalidade);
            
            foreach (Models.TbAlunoResponsavel responsavel in request.Responsaveis)
            {
                request.Responsavel.IdAluno = request.Aluno.IdAluno;
                AlunoResponsavelBusiness.Inserir(request.Responsavel);
            }
            
            request.TurmaAluno.IdAluno = request.Aluno.IdAluno;
            AlunoTurmaBusiness.Inserir(request.TurmaAluno);

            request.Carometro.IdAluno = request.Aluno.IdAluno;
            AlunoCarometroBusiness.Inserir(request.Carometro);
        }

         public void alterar (MatriculaRequest request)
        {
            this.ValidacaoAluno(request.Aluno);
            this.ValidacaoCarometro(request.Carometro);
            this.ValidacaoMensalidade(request.Mensalidade);
            this.ValidacaoResponsavel(request.Responsavel);
            this.ValidarTurmaAluno(request.TurmaAluno);


             AlunoBusiness.Alterar(request.Aluno);

            request.Documentos.IdAluno = request.Aluno.IdAluno;
            AlunoDocumentosBusiness.Alterar(request.Documentos);

            request.FichaMedica.IdAluno = request.Aluno.IdAluno;
            AlunoFichaMedicaBusiness.Alterar(request.FichaMedica);

            request.Localizacao.IdAluno = request.Aluno.IdAluno;
            AlunoLocalizacaoBusiness.Alterar(request.Localizacao);

            request.Mensalidade.IdAluno = request.Aluno.IdAluno;
            AlunoMensalidadeBusiness.alterar(request.Mensalidade);

            request.Responsavel.IdAluno = request.Aluno.IdAluno;
            AlunoResponsavelBusiness.Alterar(request.Responsavel);

            request.TurmaAluno.IdAluno = request.Aluno.IdAluno;
            AlunoTurmaBusiness.Alterar(request.TurmaAluno);

            request.Carometro.IdAluno = request.Aluno.IdAluno;
            AlunoCarometroBusiness.Alterar(request.Carometro);
        }

        public void Deletar (int id)
        {
            AlunoDocumentosBusiness.Deletar(id);
            
            AlunoFichaMedicaBusiness.Deletar(id);
            
            AlunoLocalizacaoBusiness.Deletar(id);
            
            AlunoMensalidadeBusiness.Deletar(id);

            AlunoResponsavelBusiness.Deletar(id);

            AlunoCarometroBusiness.Deletar(id);
            
            AlunoTurmaBusiness.Deletar(id);

            AlunoBusiness.Deletar(id);
        }

        public List<Models.MatriculaResponse> Lista (string nome, string ra, string curso, string turma, int idanoletivo)
        {
            List<Models.TbAluno> Alunos = AlunoBusiness.ConsultarPorNome(nome, ra, curso, turma, idanoletivo);

            List<Models.MatriculaResponse> Response = new List<MatriculaResponse>();
            foreach (Models.TbAluno Aluno in Alunos)
            {
                Models.MatriculaResponse r = CriarResponse(Aluno);
                Response.Add(r);
            }

            return Response;

        }

        public List<MatriculaResponse> ListarTodos()
        {
                List<Models.TbAluno> Alunos = AlunoBusiness.ListarTodos();

            List<Models.MatriculaResponse> Response = new List<MatriculaResponse>();
            foreach (Models.TbAluno Aluno in Alunos)
            {
                Models.MatriculaResponse r = CriarResponse(Aluno);
                Response.Add(r);
            }            
             return Response;
        }



        public Models.MatriculaResponse CriarResponse(Models.TbAluno Aluno)
        {
            Models.MatriculaResponse Response = new MatriculaResponse();
           
            Response.IdAluno = Aluno.IdAluno;
            Response.DsRg = Aluno.DsRg;
            Response.NmAluno = Aluno.NmAluno;

            if (Aluno.TbTurmaAluno.Count > 0)
            {
                Response.CdRa = Aluno.TbTurmaAluno.FirstOrDefault().CdRa;
                Response.DsStatus = Aluno.TbTurmaAluno.FirstOrDefault().TpStatus;
                Response.NmTurma = Aluno.TbTurmaAluno.FirstOrDefault().IdTurmaNavigation.NmTurma;
                Response.TpPeriudo = Aluno.TbTurmaAluno.FirstOrDefault().IdTurmaNavigation.TpPeriodo;
                Response.NmCurso = Aluno.TbTurmaAluno.FirstOrDefault().IdTurmaNavigation.IdCursoNavigation.NmCurso;
                Response.TurmaAluno = Aluno.TbTurmaAluno.FirstOrDefault();
            }
            
            Response.Aluno = Aluno;
            Response.Documentos = Aluno.TbAlunoDocumentos.ToList();
            Response.Localizacao = Aluno.TbAlunoLocalizacao.ToList();
            Response.FichaMedica = Aluno.TbAlunoFichaMedica.ToList();
            Response.Responsavel = Aluno.TbAlunoResponsavel.ToList();
 

            return Response;
        }







// validações

private void ValidacaoAluno (Models.TbAluno aluno)
        {

            Models.TbAluno Individuo = AlunoDB.Carregar(aluno);
            int diferença = Convert.ToInt32(DateTime.Now.Year - aluno.DtNascimento.Year);

            if (aluno.NmAluno == string.Empty)
            throw new ArgumentException("O campo de Nome é obrigatorio");

            if (aluno.NmEscola == string.Empty)
            throw new ArgumentException("O campo Escola é obrigatorio");

            else if (aluno.DsCpf.Length != 14 && aluno.DsCpf == null)
            throw new ArgumentException ("Este CPF esta invalido");

            else if (aluno.DsEmail.Contains("@") == false && aluno.DsEmail.Contains(".com") == false)
            throw new ArgumentException ("Este Email esta invalido");

            else if (aluno.DsEmail == string.Empty)
            throw new ArgumentException ("O campo de Email é obrigatorio");

            else if (aluno.DsRg.Length != 10)
            throw new ArgumentException("O RG esta invalido");

            else if (aluno.DsRg == string.Empty)
            throw new ArgumentException("O campo de RG é obrigatorio");

            else if (aluno.DtEmissao == null)
            throw new ArgumentException("O campo de Emissão é obrigatorio");

            else if (aluno.DtNascimento == null)
            throw new ArgumentException("O campo de Data de Nascimento é obrigatorio");

            else if (diferença <=14 || diferença >=25 )
            throw new ArgumentException("O individuo não tem a idade necessária para ingressar no curso");
        }

        public void ValidacaoCarometro(Models.TbAlunoDocumentos documentos)
        {
             if(documentos.NmDocumento == string.Empty)
            {
                throw new ArgumentException("O Nome do documento é obrigatorio ");
            }
            if(documentos.DtInclusao > DateTime.Now)
            {
                throw new ArgumentException("A data de inclusão não pode ser mais q a data de hoje");
            }
            
        }

         public void ValidacaoLocalizacao(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
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

        public void ValidacaoMensalidade(Models.TbAlunoMensalidade ModelAlunoMensalidade)
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

         public void ValidacaoResponsavel(Models.TbAlunoResponsavel ModelAlunoResponsavel)
        {
            if(ModelAlunoResponsavel.DsEmail.Contains("@") == false && ModelAlunoResponsavel.DsEmail.Contains(".com") == false)
            {   
                throw new Exception("Este Email esta inválido");
            }
            else if(ModelAlunoResponsavel.DsEmail == string.Empty)
            {
                throw new Exception("E-mail é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsParentesco == string.Empty)
            {
                throw new Exception("Parentesco é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsRg == string.Empty)
            {
                throw new Exception("Rg é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsTelefone1 == string.Empty)
            {
                throw new Exception("Telefone 1 é obrigatório");
            }
            else if(ModelAlunoResponsavel.DsTelefone2 == string.Empty)
            {
                throw new Exception("Telefone 2 é obrigatório");
            }
            else if(ModelAlunoResponsavel.NmResponsavel == string.Empty)
            {
                throw new Exception("Responsavel é obrigatório");
            }
        }

        public void ValidacaoCarometro(Models.TbAlunoCarometro carometro)
        {
            if (carometro.DsImagem == string.Empty)
            throw new ArgumentException("Selecione uma imagem");
        }

         public void ValidarTurmaAluno(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno Model = TurmaAlunoDB.Consultar(turmaAluno);

            if (turmaAluno.NrChamada <= 0)
            throw new ArgumentException("Este número não é valido");

            else if (turmaAluno.CdRa == string.Empty)
            throw new ArgumentException("Este RA não é valido");

            else if (turmaAluno.TpStatus == string.Empty)
            throw new ArgumentException("O campo de Status é obrigatorio");

            else if (turmaAluno.DsObservacao == string.Empty)
            throw new ArgumentException("O campo de Observação é obrigatorio");
        }
    }
}