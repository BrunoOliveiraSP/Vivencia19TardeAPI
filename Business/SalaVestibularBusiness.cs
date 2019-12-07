using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class SalaVestibularBusiness
    {
        Database.SalaDataBase sala = new Database.SalaDataBase();
        Database.SalaVestibularDataBase db = new Database.SalaVestibularDataBase();
        public void Inserir(Models.SalaVestibularRequest request)
        {
            this.ValidarSala(request.Sala);

            db.Inserir(request.Vestibular);

            request.Vestibular.IdSala = request.Sala.IdSala;
            sala.inserir(request.Sala);
        }

        public void ValidarSala(Models.TbSala sala)
        {
            if(sala.NmSala == string.Empty)
            throw new ArgumentException("Sala Obrigatória.");

            if(sala.NmLocal == string.Empty)
            throw new ArgumentException("Instituição obrigatório.");                      
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