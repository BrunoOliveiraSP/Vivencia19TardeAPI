using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoMensalidadeDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbAlunoMensalidade ModelAlunoMensalidade)
        {
            db.Add(ModelAlunoMensalidade);
        }

        public List<Models.TbAlunoMensalidade> ListarTodos()
        {
            List<Models.TbAlunoMensalidade> Lista = db.TbAlunoMensalidade.ToList();

            return Lista;
        } 

        

        public void Deletar(int id)
        {
            Models.TbAlunoMensalidade remover = db.TbAlunoMensalidade.FirstOrDefault(a => a.IdAluno == id);

            db.Remove(remover);
        }
    }
}