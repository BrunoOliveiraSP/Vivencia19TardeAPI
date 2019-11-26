using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DisciplinaController
    {
        Business.DisciplinaBusiness bu = new Business.DisciplinaBusiness();

        [HttpPost]
        public void Inserir(Models.TbDisciplina disc)
        {
            bu.Inserir(disc);
        }
    }
}