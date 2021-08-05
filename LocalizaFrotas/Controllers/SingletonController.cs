﻿using LocalizaFrotasInfra.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaFrotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly SingletonContainer singletonContainer;
        public SingletonController(SingletonContainer singletonContainer)
        {
            this.singletonContainer = singletonContainer;
        }

        [HttpGet()]
        public ActionResult Get()
        {
            //var singleton = singletonContainer;
            return Ok(singletonContainer);
        }
    }
}
