using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        [HttpGet,Authorize]
        public IEnumerable<Filme> Get()
        {
            return new Filme[] {
                new Filme{ Titulo = "Matrix", Ano=1999},
                new Filme{ Titulo = "Rei Leão", Ano = 1994},
                new Filme{ Titulo = "Poderoso Chefão", Ano=1972}
            };
        }
    }

    public class Filme
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }
    }
}