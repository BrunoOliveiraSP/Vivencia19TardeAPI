using Vivencia19TardeAPI.Models;
using System;
using System.Collections;
using System.Linq;

namespace Vivencia19TardeAPI.Business
{
    public class MatriculaBusiness
    {
        AlunoBusiness alunoBusiness = new AlunoBusiness();
        DocumentosBusiness documentosBusiness = new DocumentosBusiness();


        public void Inserir(MatriculaRequest request)
        {
            // Insere na tabela principal tb_aluno
            alunoBusiness.inserir(request.Aluno);

            // Vincula a chave primária e insere em tb_aluno_documento
            request.Documentos.IdAluno = request.Aluno.IdAluno;
            documentosBusiness.Inserir(request.Documentos);

            


        }
    }
}