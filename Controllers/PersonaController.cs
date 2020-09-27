using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VueJsFeatNetCore.Controllers
{
    [Route("api/Persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public Persona GetPersona()
        {
            Persona p = new Persona()
            {
                Nombre = "juanito"

            };

            return p;
        }



    }
}

public class Persona
{
    public string Nombre { get; set; }

}
