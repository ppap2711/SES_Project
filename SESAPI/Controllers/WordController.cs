using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SESAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetWord()
        {
            return new JsonResult(
                new List<object>()
                {
                    new {id=1, Name="Hello"},
                    new {id=2, Name="test"}
                });
        }

    }
}

/*
 [HttpGet]
        public JsonResult GetWord()
        {
            return new JsonResult(
                new List<object>()
                {
                    new {id=1, Name="Hello"},
                    new {id=2, Name="test"}
                });
        }
 */