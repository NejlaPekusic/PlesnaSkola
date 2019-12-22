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
    public class UplateController : ControllerBase
    {
        private readonly IUplateService _service;

        public UplateController(IUplateService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Plesac,Roditelj")]

        public List<Model.Uplate> Get([FromQuery] Model.Requests.UplateSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Plesac,Roditelj")]


        public Model.Uplate GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj")]

        public Model.Uplate Insert([FromBody] Model.Requests.UplateInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj")]

        public Model.Uplate Update(int Id, [FromBody] Model.Requests.UplateInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}