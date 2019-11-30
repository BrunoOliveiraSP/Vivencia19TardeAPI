namespace Vivencia19TardeAPI.Database
{
    public class AlunoTurmaDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbTurmaAluno turmaAluno)
        {
            DB.TbTurmaAluno.Add(turmaAluno);
            DB.SaveChanges();
        }
    }
}