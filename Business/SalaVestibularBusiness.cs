using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class SalaVestibularBusiness
    {
        Database.SalaVestibularDataBase db = new Database.SalaVestibularDataBase();
        public void Inserir(Models.TbSalaVestibular sala)
        {
            db.Inserir(sala);
        }
        public List<Models.TbSalaVestibular> ListarTudo()
        {
            List<Models.TbSalaVestibular> sala = db.Listar();
            return sala;

        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
        public void Alterar(Models.TbSalaVestibular sala)
        {
            db.Alterar(sala);
        }
        
    }
}