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
    public class PravdanjaController : ControllerBase
    {
        private readonly IPravdanjaService _service;

        public PravdanjaController(IPravdanjaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Plesac,Roditelj")]

        public List<Model.Pravdanja> Get([FromQuery] Model.Requests.PravdanjaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Plesac,Roditelj")]


        public Model.Pravdanja GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj,Plesac,Roditelj")]

        public Model.Pravdanja Insert([FromBody] Model.Requests.PravdanjaInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj")]

        public Model.Pravdanja Update(int Id, [FromBody] Model.Requests.PravdanjaInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}