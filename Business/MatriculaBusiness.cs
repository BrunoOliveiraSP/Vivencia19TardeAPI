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
            AlunoBusiness.inserir(request.Aluno);

            request.Documentos.IdAluno = request.Aluno.IdAluno;
            AlunoDocumentosBusiness.Inserir(request.Documentos);

            request.FichaMedica.IdAluno = request.Aluno.IdAluno;
            AlunoFichaMedicaBusiness.Inserir(request.FichaMedica);

            request.Localizacao.IdAluno = request.Aluno.IdAluno;
            AlunoLocalizacaoBusiness.Inserir(request.Localizacao);

            request.Mensalidade.IdAluno = request.Aluno.IdAluno;
            AlunoMensalidadeBusiness.Inserir(request.Mensalidade);

            request.Responsavel.IdAluno = request.Aluno.IdAluno;
            AlunoResponsavelBusiness.Inserir(request.Responsavel);

            request.TurmaAluno.IdAluno = request.Aluno.IdAluno;
            AlunoTurmaBusiness.Inserir(request.TurmaAluno);

            request.Carometro.IdAluno = request.Aluno.IdAluno;
            AlunoCarometroBusiness.Inserir(request.Carometro);
        }

        public void alterar (MatriculaRequest request)
        {
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

        public void Deletar (MatriculaRequest request)
        {
             AlunoBusiness.Deletar(request.Aluno.IdAluno);

            request.Documentos.IdAluno = request.Aluno.IdAluno;
            AlunoDocumentosBusiness.Deletar(request.Documentos.IdAluno);

            request.FichaMedica.IdAluno = request.Aluno.IdAluno;
            AlunoFichaMedicaBusiness.Deletar(request.FichaMedica.IdAluno);

            request.Localizacao.IdAluno = request.Aluno.IdAluno;
            AlunoLocalizacaoBusiness.Deletar(request.Localizacao.IdAluno);

            request.Mensalidade.IdAluno = request.Aluno.IdAluno;
            AlunoMensalidadeBusiness.Deletar(request.Mensalidade.IdAluno);

            request.Responsavel.IdAluno = request.Aluno.IdAluno;
            AlunoResponsavelBusiness.Deletar(Convert.ToInt32(request.Responsavel.IdAluno));

            request.TurmaAluno.IdAluno = request.Aluno.IdAluno;
            AlunoTurmaBusiness.Deletar(request.TurmaAluno.IdAluno);

            request.Carometro.IdAluno = request.Aluno.IdAluno;
            AlunoCarometroBusiness.Deletar(request.Carometro.IdAluno);
        }

        public List<Models.MatriculaResponse> Lista (string Nome, string RA, string Curso, string Turma)
        {
            List<Models.TbAluno> Alunos = AlunoBusiness.ConsultarPorNome(Nome);

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

            // Business usadas
            Business.CursoBusiness CursoBusiness = new CursoBusiness();
            Business.TurmaAnoLetivo TurmaBusiness = new TurmaAnoLetivo(); 
           

            //Modelos usados
            Models.TbCurso Curso = new TbCurso();
            Models.TbTurma Turma = new TbTurma();
            Models.MatriculaResponse Response = new MatriculaResponse();
           
           
            //Informações vindas da tabela Aluno
            Response.NmAluno = Aluno.NmAluno;
            Response.DsRg = Aluno.DsRg;


            // Informações vindas da tabela Cursos
            //Usando a tabela Turma para achar a sala
            int IdTurma = Aluno.TbTurmaAluno.FirstOrDefault().IdTurma;
            Turma = TurmaBusiness.ConsultarPorID(IdTurma);
            int IdCurso = Turma.IdCurso;
            Curso = CursoBusiness.ConsultarPorID(IdCurso);

            Response.NmCurso = Curso.NmCurso;


            //Informções vindas da tabela curso
            // os quais o modelo á foi achado no "bloco" acima
            Response.NmTurma = Turma.NmTurma;
            Response.TpPeriudo = Turma.TpPeriodo;
            

            //Informaçoes vindas da tabela TurmaAluno
            //Que foi add no modelo de Aluno usado
            Response.CdRa = Aluno.TbTurmaAluno.FirstOrDefault().CdRa;
            Response.DsStatus = Aluno.TbTurmaAluno.FirstOrDefault().TpStatus;


            Response.Aluno = Aluno;
            Response.Documentos = Aluno.TbAlunoDocumentos.ToList();
            Response.Localizacao = Aluno.TbAlunoLocalizacao.ToList();
            //
            //

            return Response;
        }

    }
}