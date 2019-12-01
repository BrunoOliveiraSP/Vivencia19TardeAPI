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

    }
}