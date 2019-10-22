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
    public class PravdanjaController : ControllerBase
    {
        private readonly IPravdanjaService _service;

        public PravdanjaController(IPravdanjaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Pravdanja> Get([FromQuery] Model.Requests.PravdanjaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Pravdanja GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Pravdanja Insert([FromBody] Model.Requests.PravdanjaInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Pravdanja Update(int Id, [FromBody] Model.Requests.PravdanjaInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}