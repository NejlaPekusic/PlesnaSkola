using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlesnaSkola.WebAPI.Models;
using PlesnaSkola.WebAPI.Services;

namespace PlesnaSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj")]
        public Model.Grupe Get([FromQuery]Model.Requests.PreporukaRequest request)
        {
            return _service.Get(request);
        }

       


    }
}