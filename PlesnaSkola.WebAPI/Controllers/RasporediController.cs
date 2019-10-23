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
    public class RasporediController : ControllerBase
    {
        private readonly IRasporediService _service;

        public RasporediController(IRasporediService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Rasporedi> Get([FromQuery] Model.Requests.RasporediSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Rasporedi GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Rasporedi Insert([FromBody] Model.Requests.RasporediInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Rasporedi Update(int Id, [FromBody] Model.Requests.RasporediInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}