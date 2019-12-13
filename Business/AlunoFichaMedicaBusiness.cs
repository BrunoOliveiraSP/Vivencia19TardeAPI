using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoFichaMedicaBusiness
    {
        Database.AlunoFichaMedicaDatabase db = new Database.AlunoFichaMedicaDatabase();
        public void Inserir(Models.TbAlunoFichaMedica ModelAlunoFichaMedica)
        {
            db.Inserir(ModelAlunoFichaMedica);
        }
        public List<TbAlunoFichaMedica> Consultar()
        {
            List<TbAlunoFichaMedica> lista =db.Consultar();
            return lista;
        }
        public void Alterar(TbAlunoFichaMedica ficha)
        {
            db.Alterar(ficha);
        }
        public void Deletar(int id)
        {
            db.Deletar(id);
        }


    }
}