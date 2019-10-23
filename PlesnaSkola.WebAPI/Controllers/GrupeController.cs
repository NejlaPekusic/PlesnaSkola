using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlesnaSkola.WebAPI.Models;
using PlesnaSkola.WebAPI.Services;

namespace PlesnaSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupeController : ControllerBase
    {
        private readonly IGrupeService _service;

        public GrupeController(IGrupeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Grupe> Get([FromQuery] Model.Requests.GrupeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Grupe GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Grupe Insert([FromBody] Model.Requests.GrupeInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Grupe Update(int Id, [FromBody] Model.Requests.GrupeInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}