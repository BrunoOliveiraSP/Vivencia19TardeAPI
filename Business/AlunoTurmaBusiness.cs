namespace Vivencia19TardeAPI.Business
{
    public class AlunoTurmaBusiness
    {
        Database.AlunoTurmaDatabase DB = new Database.AlunoTurmaDatabase();

        public void Inserir(Models.TbTurmaAluno turmaAluno)
        {

            DB.Inserir(turmaAluno);
        }
    }
}