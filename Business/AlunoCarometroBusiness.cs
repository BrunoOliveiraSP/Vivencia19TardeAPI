using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Business
{
    public class AlunoCarometroBusiness
    {
        Database.AlunoCarometroDatabase DB = new Database.AlunoCarometroDatabase();

        public void Inserir (Models.TbAlunoCarometro carometro)
        {
            DB.inserir(carometro);
        }

        public List<Models.TbAlunoCarometro> ListarTodos()
        {
            List<Models.TbAlunoCarometro> Lista = DB.ListarTodos();
            return Lista;
        }

        public void Alterar (Models.TbAlunoCarometro carometro)
        {
            DB.alterar(carometro);
        }

        public void Deletar (int id)
        {
            DB.deletar(id);
        }
        

        
    }
}