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
    public class RadioniceController : ControllerBase
    {
        private readonly IRadioniceService _service;

        public RadioniceController(IRadioniceService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Radionice> Get([FromQuery] Model.Requests.RadioniceSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Radionice GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Radionice Insert([FromBody] Model.Requests.RadioniceInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Radionice Update(int Id, [FromBody] Model.Requests.RadioniceInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}