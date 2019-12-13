using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Business
{
    public class AlunoCarometroBusiness
    {
        Database.AlunoCarometroDatabase db = new Database.AlunoCarometroDatabase();

        public void Inserir (Models.TbAlunoCarometro carometro)
        {
            db.inserir(carometro);
        }

        public List<Models.TbAlunoCarometro> ListarTodos()
        {
            List<Models.TbAlunoCarometro> Lista = db.ListarTodos();
            return Lista;
        }

        public void Alterar (Models.TbAlunoCarometro carometro)
        {
            db.alterar(carometro);
        }

        public void Deletar (int id)
        {
            db.deletar(id);
        }
        

        
    }
}