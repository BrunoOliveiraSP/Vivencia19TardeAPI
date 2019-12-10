using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Models
{
    public class ProfessorResponse
    {
        public int IdProfessor { get; set; }
        public int IdLogin { get; set; }
        public string NmProfessor { get; set; }
        public string DsCelular { get; set; }
        public string DsTelefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string DsEstado { get; set; }
        public string DsEmail { get; set; }
        public string DsCvLattes { get; set; }
        public int NrAnoPrimeiroEmprego { get; set; }
        public string DsCpf { get; set; }
        public string DsRg { get; set; }
        public string DsRgOrgao { get; set; }
        public string DsRgEmissor { get; set; }
        public string NmMae { get; set; }
        public string NmPai { get; set; }
        public string TpContratacao { get; set; }
        public bool BtAtivo { get; set; }
        public string DsFaculdade { get; set; }
        public string DsCurso { get; set; }
        public DateTime DtFaculdadeInicio { get; set; }
        public DateTime DtFaculdadeFim { get; set; }
        public string DsLogin { get; set; }
    }
}