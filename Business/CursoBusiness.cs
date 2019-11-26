using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Business
{
    
    
    public class CursoBusiness
    {
        Database.cursoDatabase db = new Database.cursoDatabase();
        
        public void Inserir (Models.TbCurso curso) 
        {
            if(curso.NmCurso == string.Empty)
            throw new ArgumentException("Campo vazio.");            

            if(curso.DsSigla == string.Empty)
            throw new ArgumentException("Campo vazio.");

            if(curso.NrCapacidadeMaxima == 0)
            throw new ArgumentException("Valor inválido.");

            if(curso.DsCategoria == string.Empty)
            throw new ArgumentException("Escolha uma opção."); 

            db.Inserir(curso);          
        }
    }
}