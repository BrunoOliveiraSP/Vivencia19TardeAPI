using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Vivencia19TardeAPI.Models
{
    public class MatriculaResponse
    {
        //tb_Aluno
        public int IdAluno { get; set; }
        public string NmAluno { get; set; }
        public string DsRg { get; set; }
        
        // Tb_Curso
        public string NmCurso { get; set; }

        // Tb_Turma
        public string NmTurma { get; set; }
        public string TpPeriudo { get; set; }

        //Tb_Turma_Aluno
        public string CdRa { get; set; }
        public string DsStatus { get; set; }



        public Models.TbAluno Aluno { get; set; }
        public Models.TbTurmaAluno TurmaAluno { get; set; }

        public List<Models.TbAlunoDocumentos> Documentos { get; set; }
        public List<Models.TbAlunoFichaMedica> FichaMedica { get; set; }
        public List<Models.TbAlunoLocalizacao> Localizacao { get; set; }
        public List<Models.TbAlunoResponsavel> Responsavel { get; set; }

    }
}