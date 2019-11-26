using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class InscricaoDatabase 
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbInscricao inscricao)
        {
            db.TbInscricao.Add(inscricao);
            db.SaveChanges();
        }

        public List<Models.TbInscricao> ConsultarTodos()
        {
            return db.TbInscricao.ToList();
        }

        public void Remover (int id)
        {
            Models.TbInscricao remover = db.TbInscricao.First(x => x.IdInscricao == id);
            db.Remove(remover);
            db.SaveChanges();
        }

        public void Alterar(Models.TbInscricao inscrito)
        {
            Models.TbInscricao alterar = db.TbInscricao.First(x => x.IdInscricao == inscrito.IdInscricao);
            alterar.IdSalaVestibular = inscrito.IdSalaVestibular;
            alterar.IdSalaVestibularNavigation = inscrito.IdSalaVestibularNavigation;
            alterar.NmContato = inscrito.NmContato;
            alterar.NmEscola = inscrito.NmEscola;
            alterar.NmInscrito = inscrito.NmInscrito;
            alterar.NrResidenciaEndereco = inscrito.NrResidenciaEndereco;
            alterar.QtMoramCasa = inscrito.QtMoramCasa;
            alterar.QtTrabalhamCasa = inscrito.QtTrabalhamCasa;
            alterar.TpEscola = inscrito.TpEscola;
            alterar.VlNota = inscrito.VlNota;
            alterar.VlRenda = inscrito.VlRenda;
            alterar.BtMatriculado = inscrito.BtMatriculado;
            alterar.BtPendenteComprovresid = inscrito.BtPendenteComprovresid;
            alterar.BtPendenteCpf = inscrito.BtPendenteCpf;
            alterar.BtPendenteEscolaridade = inscrito.BtPendenteEscolaridade;
            alterar.BtPendentePagamento = inscrito.BtPendentePagamento;
            alterar.BtPendenteRg = inscrito.BtPendenteRg;
            alterar.CdInscricao = inscrito.CdInscricao;
            alterar.DsComoConheceu = inscrito.DsComoConheceu;
            alterar.DsCorPele = inscrito.DsCorPele;
            alterar.DsCpf = inscrito.DsCpf;
            alterar.DsCurso2Periodo = inscrito.DsCurso2Periodo;
            alterar.DsCursoPeriodo = inscrito.DsCursoPeriodo;
            alterar.DsEmail = inscrito.DsEmail;
            alterar.DsEmailInscrito = inscrito.DsEmailInscrito;
            alterar.DsEscolaridade = inscrito.DsEscolaridade;
            alterar.DsNascimentoCidade = inscrito.DsNascimentoCidade;
            alterar.DsNascimentoEstado = inscrito.DsNascimentoEstado;
            alterar.DsNascimentoPais = inscrito.DsNascimentoPais;
            alterar.DsObservacao = inscrito.DsObservacao;
            alterar.DsOrgao = inscrito.DsOrgao;
            alterar.DsResidenciaBairro = inscrito.DsResidenciaBairro;
            alterar.DsResidenciaCep = inscrito.DsResidenciaCep;
            alterar.DsResidenciaCidade = inscrito.DsResidenciaCidade;
            alterar.DsResidenciaComplelemento = inscrito.DsResidenciaComplelemento;
            alterar.DsResidenciaEndereco = inscrito.DsResidenciaEndereco;
            alterar.DsResidenciaEstado = inscrito.DsResidenciaEstado;
            alterar.DsResponsavelCpf = inscrito.DsResponsavelCpf;
            alterar.DsResponsavelEmail = inscrito.DsResponsavelEmail;
            alterar.DsResponsavelNome = inscrito.DsResponsavelNome;
            alterar.DsResponsavelParentesco = inscrito.DsResponsavelParentesco;
            alterar.DsResponsavelRg = inscrito.DsResponsavelRg;
            alterar.DsResponsavelTelefone = inscrito.DsResponsavelTelefone;
            alterar.DsResponsavelTelefone2 = inscrito.DsResponsavelTelefone2;
            alterar.DsRg = inscrito.DsRg;
            alterar.DsSexo = inscrito.DsSexo;
            alterar.DsSituacao = inscrito.DsSituacao;
            alterar.DsTelefone = inscrito.DsTelefone;
            alterar.DsTelefone2 = inscrito.DsTelefone2;
            alterar.DtEmissao = inscrito.DtEmissao;
            alterar.DtInclusao = inscrito.DtInclusao;
            alterar.DtNascimento = inscrito.DtNascimento;
            alterar.DtUltimaAlteracao = inscrito.DtUltimaAlteracao;
            alterar.IdAnoLetivo = inscrito.IdAnoLetivo;
            alterar.IdAnoLetivoNavigation = inscrito.IdAnoLetivoNavigation;
            alterar.IdCurso = inscrito.IdCurso;
            alterar.IdCurso2 = inscrito.IdCurso2;
            alterar.IdCurso2Navigation = inscrito.IdCurso2Navigation;
            alterar.IdCursoNavigation = inscrito.IdCursoNavigation;
            alterar.IdFuncionarioAlteracao = inscrito.IdFuncionarioAlteracao;
            
            db.SaveChanges();
        }
    }
}