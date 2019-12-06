using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Vivencia19TardeAPI.Models
{
    public class MatriculaResponse
    {

        //tb_Aluno
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
    }
}