using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class AlunoCarometroDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();

        public void inserir (Models.TbAlunoCarometro carometro)
        {
            DB.TbAlunoCarometro.Add(carometro);
            DB.SaveChanges();
        }

        public List<Models.TbAlunoCarometro> ListarTodos()
        {
            List<Models.TbAlunoCarometro> lista = DB.TbAlunoCarometro.ToList();
            return lista;
        }

        public void alterar (Models.TbAlunoCarometro carometro)
        {
            Models.TbAlunoCarometro novo = DB.TbAlunoCarometro.FirstOrDefault(x=> x.IdAluno == carometro.IdAluno);

            novo.DsImagem = carometro.DsImagem;

            DB.SaveChanges();
        }

        public void deletar (int id)
        {
            Models.TbAlunoCarometro remover = DB.TbAlunoCarometro.FirstOrDefault(x=> x.IdAluno == id);

            DB.Remove(id);
            DB.SaveChanges();
        }
    }
}