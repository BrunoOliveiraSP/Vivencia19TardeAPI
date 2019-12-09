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
        Database.AlunoTurmaDatabase DB = new Database.AlunoTurmaDatabase();

        public void Inserir(Models.TbTurmaAluno turmaAluno)
        {

            DB.Inserir(turmaAluno);
        }

        public void Alterar (Models.TbTurmaAluno turmaAluno)
        {
            DB.Alterar(turmaAluno);
        }

        public List<Models.TbTurmaAluno> ListarTodos()
        {
            List<Models.TbTurmaAluno> lista = DB.Listar();
            return lista;
        }

        public Models.TbTurmaAluno Consultar(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno Model = DB.Consultar(turmaAluno);
            return Model;
        }
        public void Deletar (int id)
        {
            DB.Deletar(id);
        }

       
    }
}