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
        Database.AlunoFichaMedicaDatabase dt = new Database.AlunoFichaMedicaDatabase();
        public void Inserir(Models.TbAlunoFichaMedica ModelAlunoFichaMedica)
        {
            dt.Inserir(ModelAlunoFichaMedica);
        }
        public List<TbAlunoFichaMedica> Consultar()
        {
            List<TbAlunoFichaMedica> lista =dt.Consultar();
            return lista;
        }
        public void Alterar(TbAlunoFichaMedica ficha)
        {
            dt.Alterar(ficha);
        }
        public void Deletar(int id)
        {
            dt.Deletar(id);
        }
    }
}