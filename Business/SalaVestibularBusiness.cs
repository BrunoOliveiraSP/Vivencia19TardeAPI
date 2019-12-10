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
        public void Inserir(Models.TbSalaVestibular request)
        {
            

            db.Inserir(request);

            
        }

        public void ValidarSala(Models.TbSala sala)
        {
            if(sala.NmSala == string.Empty)
            throw new ArgumentException("Sala Obrigatória.");

            if(sala.NmLocal == string.Empty)
            throw new ArgumentException("Instituição obrigatório.");                      
        } 

        
  public List<Models.SalaVestibularResponse> ListarTudo()
        {
            List<Models.TbSalaVestibular> Vestibular = db.Listar();
           
            List<Models.SalaVestibularResponse> Response = new List<Models.SalaVestibularResponse>();
            
            foreach(Models.TbSalaVestibular salavestibular in Vestibular)
            {
                Models.SalaVestibularResponse resp = CriarResponse(salavestibular);
                Response.Add(resp);
            }
            
            return Response;
        }

        public Models.SalaVestibularResponse CriarResponse(Models.TbSalaVestibular vestibular)
        {
            Models.SalaVestibularResponse response = new Models.SalaVestibularResponse();

            response.IdSalaVestibular = vestibular.IdSalaVestibular;
            response.DsPeriodo = vestibular.DsPeriodo;
            response.NmLocal = vestibular.IdSalaNavigation.NmLocal;
            response.NmSala = vestibular.IdSalaNavigation.NmSala;
            
            return response;
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