using Vivencia19TardeAPI.Models;
using System;
using System.Collections;
using System.Linq;

namespace Vivencia19TardeAPI.Business
{
    public class MatriculaBusiness
    {
        AlunoBusiness alunoBusiness = new AlunoBusiness();
        AlunoDocumentosBusiness documentosBusiness = new AlunoDocumentosBusiness();

        AlunoFichaMedicaBusiness alunoFichaMedicaBusiness = new AlunoFichaMedicaBusiness();

        AlunoLocalizacaoBusiness alunoLocalizacaoBusiness = new AlunoLocalizacaoBusiness();
        AlunoMensalidadeBusiness alunoMensalidadeBusiness = new AlunoMensalidadeBusiness();
        AlunoResponsavelBusiness responsavelBusiness = new AlunoResponsavelBusiness();
        AlunoTurmaBusiness alunoTurmaBusiness = new AlunoTurmaBusiness();

        public void Inserir(MatriculaRequest request)
        {
            // Insere na tabela principal tb_aluno
            alunoBusiness.inserir(request.Aluno);

            // Vincula a chave primária e insere em tb_aluno_documento
            request.Documentos.IdAluno = request.Aluno.IdAluno;
            documentosBusiness.Inserir(request.Documentos);


            request.FichaMedica.IdAluno = request.Aluno.IdAluno;
            alunoFichaMedicaBusiness.Inserir(request.FichaMedica);


            request.Localizacao.IdAluno = request.Aluno.IdAluno;
            alunoLocalizacaoBusiness.Inserir(request.Localizacao);

            request.Mensalidade.IdAluno = request.Aluno.IdAluno;
            alunoMensalidadeBusiness.Inserir(request.Mensalidade);

           request.Responsavel.IdAluno = request.Aluno.IdAluno;
           responsavelBusiness.Inserir(request.Responsavel);

           request.TurmaAluno.IdAluno = request.Aluno.IdAluno;
           alunoTurmaBusiness.Inserir(request.TurmaAluno);

            


        }
    }
}