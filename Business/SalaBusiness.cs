using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Business
{
    public class SalaBusiness
    {
        Database.SalaDataBase db = new Database.SalaDataBase();
        public void Inserir(Models.TbSala sala)
        {
            db.inserir(sala);           
        }
        public List<Models.TbSala> ListarTudo()
        {
            List<Models.TbSala> sala = db.Listar();
            return sala;

        }
        public void Remover(int id)
        {
            db.remover(id);
        }
        public void Alterar(Models.TbSala sala)
        {
            db.alterar(sala);
        }
        public List<Models.TbSala> ConsultarPorInstituicao(string instituicao)
        {
            List<Models.TbSala> consultar = db.ConsultarPorInstituicao(instituicao);
            return consultar;
        }
        
    }
}