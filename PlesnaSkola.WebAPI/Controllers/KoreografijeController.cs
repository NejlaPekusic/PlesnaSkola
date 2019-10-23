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
    public class KoreografijeController : ControllerBase
    {
        private readonly IKoreografijeService _service;

        public KoreografijeController(IKoreografijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Koreografije> Get([FromQuery] Model.Requests.KoreografijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Koreografije GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Koreografije Insert([FromBody] Model.Requests.KoreografijeInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Koreografije Update(int Id, [FromBody] Model.Requests.KoreografijeInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}