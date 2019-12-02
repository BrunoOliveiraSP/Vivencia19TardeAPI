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

            this.Validacao(sala);

            db.inserir(sala);           
        }
        public void Validacao(Models.TbSala sala)
        {
            if(sala.NmLocal == string.Empty)
            {
                throw new ArgumentException("Local obrigatório");
            }
            if(sala.NmSala == string.Empty)
            {
                throw new ArgumentException("Sala obrigatório");
            }         

        }
        public List<Models.TbSala> ListarTudo()
        {
            List<Models.TbSala> sala = db.Listar();
            return sala;

        }
        public void Verificacao(Models.TbSala sala)
        {
            if(sala.IdSala == 0)
            {
                this.Inserir(sala);
            }
            if(sala.IdSala >= 1)
            {
                this.Alterar(sala);
            }
            
        }
        public void Remover(int id)
        {
            db.remover(id);
        }
        public void Alterar(Models.TbSala sala)
        {
            if(sala.IdSala == 0)
            {
                throw new ArgumentException("ID inválido");
            }

            db.alterar(sala);
        }
        public List<Models.TbSala> ConsultarPorInstituicao(string instituicao)
        {
            List<Models.TbSala> consultar = db.ConsultarPorInstituicao(instituicao);
            return consultar;
        }
        
    }
}