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
    public class ObavijestiController : ControllerBase
    {
        private readonly IObavijestiService _service;

        public ObavijestiController(IObavijestiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Obavijesti> Get([FromQuery] Model.Requests.ObavijestiSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Obavijesti GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Obavijesti Insert([FromBody] Model.Requests.ObavijestiInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Obavijesti Update(int Id, [FromBody] Model.Requests.ObavijestiInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}