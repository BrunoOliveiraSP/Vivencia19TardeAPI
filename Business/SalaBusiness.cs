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
        
    }
}