using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

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
            return db.TbInscricao.Include(x => x.IdSalaVestibularNavigation)
                                 .Include(x => x.IdSalaVestibularNavigation.IdSalaNavigation)
                                 .Include(x => x.IdCursoNavigation)
                                 .OrderBy(x => x.NmInscrito)
                                 .ToList();
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
            alterar.DsRg = inscrito.DsRg;
            alterar.DsCpf = inscrito.DsCpf;
            alterar.DsSexo = inscrito.DsSexo;
            alterar.VlNota = inscrito.VlNota;
            alterar.DsEmail = inscrito.DsEmail;
            alterar.DsOrgao = inscrito.DsOrgao;
            alterar.IdCurso = inscrito.IdCurso;
            alterar.VlRenda = inscrito.VlRenda;
            alterar.IdCurso2 = inscrito.IdCurso2;
            alterar.NmEscola = inscrito.NmEscola;
            alterar.TpEscola = inscrito.TpEscola;
            alterar.NmContato = inscrito.NmContato;
            alterar.DsCorPele = inscrito.DsCorPele;
            alterar.DtEmissao = inscrito.DtEmissao;
            alterar.DtInclusao = inscrito.DtInclusao;
            alterar.DsSituacao = inscrito.DsSituacao;
            alterar.DsTelefone = inscrito.DsTelefone;
            alterar.NmInscrito = inscrito.NmInscrito;
            alterar.IdAnoLetivo = inscrito.IdAnoLetivo;
            alterar.DsTelefone2 = inscrito.DsTelefone2;
            alterar.QtMoramCasa = inscrito.QtMoramCasa;
            alterar.CdInscricao = inscrito.CdInscricao;
            alterar.BtPendenteRg = inscrito.BtPendenteRg;
            alterar.DsObservacao = inscrito.DsObservacao;
            alterar.DtNascimento = inscrito.DtNascimento;
            alterar.BtMatriculado = inscrito.BtMatriculado;
            alterar.BtPendenteCpf = inscrito.BtPendenteCpf;
            alterar.DsCursoPeriodo = inscrito.DsCursoPeriodo;
            alterar.DsComoConheceu = inscrito.DsComoConheceu;
            alterar.DsEscolaridade = inscrito.DsEscolaridade;
            alterar.DsCurso2Periodo = inscrito.DsCurso2Periodo;
            alterar.DsResidenciaCep = inscrito.DsResidenciaCep;
            alterar.DsEmailInscrito = inscrito.DsEmailInscrito;
            alterar.DsResponsavelRg = inscrito.DsResponsavelRg;
            alterar.QtTrabalhamCasa = inscrito.QtTrabalhamCasa;
            alterar.IdSalaVestibular = inscrito.IdSalaVestibular;
            alterar.DsResponsavelCpf = inscrito.DsResponsavelCpf;
            alterar.DsNascimentoPais = inscrito.DsNascimentoPais;
            alterar.DsResponsavelNome = inscrito.DsResponsavelNome;
            alterar.DtUltimaAlteracao = inscrito.DtUltimaAlteracao;
            alterar.IdCursoNavigation = inscrito.IdCursoNavigation;
            alterar.IdCurso2Navigation = inscrito.IdCurso2Navigation;
            alterar.DsNascimentoCidade = inscrito.DsNascimentoCidade;
            alterar.DsNascimentoEstado = inscrito.DsNascimentoEstado;
            alterar.DsResidenciaBairro = inscrito.DsResidenciaBairro;
            alterar.DsResidenciaCidade = inscrito.DsResidenciaCidade;
            alterar.DsResponsavelEmail = inscrito.DsResponsavelEmail;
            alterar.DsResidenciaEstado = inscrito.DsResidenciaEstado;
            alterar.BtPendentePagamento = inscrito.BtPendentePagamento;
            alterar.NrResidenciaEndereco = inscrito.NrResidenciaEndereco;
            alterar.DsResidenciaEndereco = inscrito.DsResidenciaEndereco;
            alterar.IdAnoLetivoNavigation = inscrito.IdAnoLetivoNavigation;
            alterar.DsResponsavelTelefone = inscrito.DsResponsavelTelefone;
            alterar.BtPendenteComprovresid = inscrito.BtPendenteComprovresid;
            alterar.BtPendenteEscolaridade = inscrito.BtPendenteEscolaridade;
            alterar.DsResponsavelTelefone2 = inscrito.DsResponsavelTelefone2;
            alterar.IdFuncionarioAlteracao = inscrito.IdFuncionarioAlteracao;
            alterar.DsResponsavelParentesco = inscrito.DsResponsavelParentesco;
            alterar.DsResidenciaComplelemento = inscrito.DsResidenciaComplelemento;
            alterar.IdSalaVestibularNavigation = inscrito.IdSalaVestibularNavigation;
            
            db.SaveChanges();
        }

        public List<Models.TbInscricao> ConsultarPorNome(string nome)
        {
            return db.TbInscricao.Include(x => x.IdSalaVestibularNavigation)
                                 .Include(x => x.IdSalaVestibularNavigation.IdSalaNavigation)
                                 .Include(x => x.IdCursoNavigation)
                                 .Where(x => x.NmInscrito.ToUpper().Contains(nome.ToUpper())   || 
                                             x.NmInscrito.ToLower().Contains(nome.ToLower()))
                                 .OrderBy(x => x.NmInscrito)
                                 .ToList();
        }

        public List<Models.TbInscricao> ConsultarPorAno(int id)
        {
            return db.TbInscricao.Include(x => x.IdSalaVestibularNavigation)
                                 .Include(x => x.IdSalaVestibularNavigation.IdSalaNavigation)
                                 .Include(x => x.IdCursoNavigation)
                                 .Where(x => x.IdAnoLetivo == id)
                                 .OrderBy(x => x.CdInscricao)
                                 .ToList();
        }

        

        public List<Models.TbInscricao> ConsultarPorNomeEAno(string nome, int idAnoLetivo)
        {
            var lista = db.TbInscricao.Include(x => x.IdSalaVestibularNavigation)
                                      .Include(x => x.IdSalaVestibularNavigation.IdSalaNavigation)
                                      .Include(x => x.IdCursoNavigation)
                                      .Where(x => x.IdAnoLetivo == idAnoLetivo 
                                               && x.NmInscrito.ToLower().Contains(nome.ToLower()))                                 
                                      .OrderBy(x => x.CdInscricao)
                                      .ToList();
            return lista;
        }

        public bool ExisteCandidato(string candidato, int idAno)
        {
            return db.TbInscricao.Any(x => x.NmInscrito == candidato &&
                                      x.IdAnoLetivo == idAno);
        }

        public bool ExisteCodigoInscrição(int codigo, int idAnoLetivo)
        {
            return  db.TbInscricao.Any(x => x.CdInscricao == codigo && x.IdAnoLetivo == idAnoLetivo) ;
        }

        public bool ExisteRG(string rg, int idAnoLetivo)
        {
            return db.TbInscricao.Any(x => x.DsRg == rg && x.IdAnoLetivo == idAnoLetivo);
        }

        public bool ExisteCpf(string cpf, int idAnoLetivo)
        {
            return db.TbInscricao.Any(x => x.DsCpf == cpf && x.IdAnoLetivo == idAnoLetivo);
        }
    }
}