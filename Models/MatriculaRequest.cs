namespace Vivencia19TardeAPI.Models
{
    public class MatriculaRequest
    {
        public TbAluno Aluno { get; set; }
        public TbAlunoDocumentos Documentos { get; set; }
        public TbAlunoFichaMedica FichaMedica {get;set;}
    }
}