using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoFichaMedicaDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbAlunoFichaMedica ModelAlunoFichaMedica)
        {
            db.Add(ModelAlunoFichaMedica);
        }

        public List<Models.TbAlunoFichaMedica> Consultar()
        {
            List<Models.TbAlunoFichaMedica> Lista = db.TbAlunoFichaMedica.ToList();

            return Lista;
        } 

        public void Alterar(TbAlunoFichaMedica ficha)
        {
            Models.TbAlunoFichaMedica alterar = db.TbAlunoFichaMedica.FirstOrDefault(t => t.IdAluno == ficha.IdAluno);

            alterar.DsAcompanhamento = ficha.DsAcompanhamento;
            alterar.DsAlergias = ficha.DsAlergias;
            alterar.DsCongenitas = ficha.DsCongenitas;
            alterar.DsMedicacao = ficha.DsMedicacao;
            alterar.DsObservacao= ficha.DsObservacao;
            alterar.DsTratamento = ficha.DsTratamento;
            alterar.DtInclusao = ficha.DtInclusao;
            alterar.DtUltimaAlteracao = ficha.DtUltimaAlteracao;

            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Models.TbAlunoFichaMedica remover = db.TbAlunoFichaMedica.FirstOrDefault(a => a.IdAluno == id);

            db.Remove(remover);
        }
    }
}