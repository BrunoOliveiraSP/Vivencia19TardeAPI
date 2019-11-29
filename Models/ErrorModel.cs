namespace Vivencia19TardeAPI.Models
{
    public class ErrorModel
    {
        public int CodigoErro {get; set;}

        public string Mensagem{get; set;}

        public ErrorModel(int codigo, string mensagem)
        {
            this.CodigoErro = codigo;
            this.Mensagem = mensagem;
        }
    }
}