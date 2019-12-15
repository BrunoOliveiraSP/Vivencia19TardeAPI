using Vivencia19TardeAPI.Models;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;

namespace Vivencia19TardeAPI.Models
{
    public class MatriculaRequest
    {
        public TbAluno Aluno { get; set; }
        public TbAlunoDocumentos Documentos { get; set; }
        public TbAlunoFichaMedica FichaMedica {get;set;}
        public TbAlunoCarometro Carometro{get;set;}
        public TbAlunoLocalizacao Localizacao{get;set;}
        public TbAlunoMensalidade Mensalidade{get;set;}
        public TbAlunoResponsavel Responsavel {get;set;}
        public TbTurmaAluno TurmaAluno {get;set;}

        public List<Models.TbAlunoResponsavel> Responsaveis { get ; set ;}
    }
}