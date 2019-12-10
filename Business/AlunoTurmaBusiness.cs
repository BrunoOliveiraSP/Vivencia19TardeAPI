using Vivencia19TardeAPI.Models;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
namespace Vivencia19TardeAPI.Business
{
    public class AlunoTurmaBusiness
    {
        Database.AlunoTurmaDatabase db = new Database.AlunoTurmaDatabase();

        public void Inserir(Models.TbTurmaAluno turmaAluno)
        {

            db.Inserir(turmaAluno);
        }

        public void Alterar (Models.TbTurmaAluno turmaAluno)
        {
            db.Alterar(turmaAluno);
        }

        public List<Models.TbTurmaAluno> ListarTodos()
        {
            List<Models.TbTurmaAluno> lista = db.Listar();
            return lista;
        }

        public Models.TbTurmaAluno Consultar(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno Model = db.Consultar(turmaAluno);
            return Model;
        }
        public void Deletar (int id)
        {
            db.Deletar(id);
        }

       
    }
}