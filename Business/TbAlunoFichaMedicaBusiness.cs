using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Business
{
    public class TbAlunoFichaMedicaBusiness
    {
        Database.TbAlunoFichaMedicaDatabase dt = new Database.TbAlunoFichaMedicaDatabase();
        public void Inserir(Models.TbAlunoFichaMedica ModelAlunoFichaMedica)
        {







            dt.Inserir(ModelAlunoFichaMedica);

        }
        public List<TbAlunoFichaMedica> Consultar()
        {


            List<TbAlunoFichaMedica> lista =dt.Consultar();
            return lista;
        }
        public void Alterar(int id,TbAlunoFichaMedica ficha)
        {
            
            
            
            
            
            
            
            
            
            dt.Alterar(id,ficha);

        }
        public void Deletar(int id)
        {



            
            dt.Deletar(id);

        }




    }
}