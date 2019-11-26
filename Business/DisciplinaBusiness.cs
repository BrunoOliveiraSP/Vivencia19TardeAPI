using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Business
{

    public class DisciplinaBusiness
    {

        Database.DisciplinaDatabase db = new Database.DisciplinaDatabase();

        public void Inserir(Models.TbDisciplina disciplina)
        {
           bool existe = db.ConsultarExistencia(disciplina);


            if(existe)
            {
                throw new ArgumentException("Disciplina já existe");
            }

           // int tamanho_sigla = disciplina.NmDisciplina.Lenght;

            // if(tamanho_sigla > 30)
            // {
            //     throw new ArgumentException("A sigla é muito extensa");
            // }
            
               db.Inserir(disciplina);
             
        }
    }
}