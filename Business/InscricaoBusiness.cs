using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class InscricaoBusiness
    {
        Database.InscricaoDatabase db = new Database.InscricaoDatabase();

        public void Inserir(Models.TbInscricao inscricao )
        {
            if (string.IsNullOrWhiteSpace(inscricao.NmInscrito))
            {
                throw new ArgumentException("Você esqueceu de colocar o nome do concorrente!"); 
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsSexo))
            {
                throw new ArgumentException("Você esqueceu de colocar o sexo do candidato");
            }
            if (string.IsNullOrWhiteSpace(inscricao.DsCpf))
            {

            }

            db.Inserir(inscricao);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }

        public void Alterar(Models.TbInscricao inscricao)
        {
            db.Alterar(inscricao);
        }

        public List<Models.TbInscricao> ConsultarTodos()
        {
            return db.ConsultarTodos();
        }



    }
}