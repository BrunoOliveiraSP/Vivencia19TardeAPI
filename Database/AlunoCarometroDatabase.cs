using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class AlunoCarometroDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void inserir (Models.TbAlunoCarometro carometro)
        {
            db.TbAlunoCarometro.Add(carometro);
            db.SaveChanges();
        }

        public List<Models.TbAlunoCarometro> ListarTodos()
        {
            List<Models.TbAlunoCarometro> lista = db.TbAlunoCarometro.ToList();
            return lista;
        }

        public void alterar (Models.TbAlunoCarometro carometro)
        {
            Models.TbAlunoCarometro novo = db.TbAlunoCarometro.FirstOrDefault(x=> x.IdAluno == carometro.IdAluno);

            novo.DsImagem = carometro.DsImagem;

            db.SaveChanges();
        }

        public void deletar (int id)
        {
            Models.TbAlunoCarometro remover = db.TbAlunoCarometro.FirstOrDefault(x=> x.IdAluno == id);

            if(remover != null)
            {
                db.Remove(remover);
                db.SaveChanges();
            }
        }
    }
}