using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoMensalidadeDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbAlunoMensalidade ModelAlunoMensalidade)
        {
            db.Add(ModelAlunoMensalidade);
            db.SaveChanges();
        }

        public List<Models.TbAlunoMensalidade> ListarTodos()
        {
            List<Models.TbAlunoMensalidade> Lista = db.TbAlunoMensalidade.ToList();

            return Lista;
        } 

        public void alterar (Models.TbAlunoMensalidade mensalidade)
        {
            Models.TbAlunoMensalidade Novo = db.TbAlunoMensalidade.FirstOrDefault(x=> x.IdAluno == mensalidade.IdAluno);

            Novo.BtIsento = mensalidade.BtIsento;
            Novo.BtPago = mensalidade.BtPago;
            Novo.DsMesref = mensalidade.DsMesref;
            Novo.DsObservacao = mensalidade.DsObservacao;
            Novo.DtInclusao = mensalidade.DtInclusao;
            Novo.DtPagamento = mensalidade.DtPagamento;
            Novo.DtUltimaAlteracao = mensalidade.DtUltimaAlteracao;
            Novo.NrFolhaCarne = mensalidade.NrFolhaCarne;
            Novo.NrOrdem = mensalidade.NrOrdem;
            Novo.NrParcela = mensalidade.NrParcela;
            Novo.TpPagamento = mensalidade.TpPagamento;
            Novo.VlMensalidade = mensalidade.VlMensalidade;

            db.SaveChanges();      
        }
        public void Deletar(int id)
        {
            Models.TbAlunoMensalidade remover = db.TbAlunoMensalidade.FirstOrDefault(a => a.IdAluno == id);

            db.Remove(remover);
        }
    }
}