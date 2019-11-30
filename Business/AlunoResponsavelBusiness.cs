using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business 
{
    public class AlunoResponsavelBusiness
    {
        
        Database.AlunoResponsavelDatabase db = new Database.AlunoResponsavelDatabase();

        public void Inserir(Models.TbAlunoResponsavel responsavel)
        {
            db.Inserir(responsavel);
        }
        public List<Models.TbAlunoResponsavel> Consultar(int id)
        {
            List<Models.TbAlunoResponsavel> lista =db.Consultar(id);

            return lista;
        }
        public void Alterar(Models.TbAlunoResponsavel responsavel)
        {
            db.Alterar(responsavel);
        }
        public void Remover(int id)
        {
            db.Remove(id);
        }
    }
}