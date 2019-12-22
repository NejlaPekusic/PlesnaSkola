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
    public class RadioniceController : ControllerBase
    {
        private readonly IRadioniceService _service;

        public RadioniceController(IRadioniceService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Asistent")]

        public List<Model.Radionice> Get([FromQuery] Model.Requests.RadioniceSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Asistent")]

        public Model.Radionice GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj,Asistent")]

        public Model.Radionice Insert([FromBody] Model.Requests.RadioniceInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj,Asistent")]

        public Model.Radionice Update(int Id, [FromBody] Model.Requests.RadioniceInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}