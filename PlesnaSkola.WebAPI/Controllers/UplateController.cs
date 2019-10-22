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
    public class UplateController : ControllerBase
    {
        private readonly IUplateService _service;

        public UplateController(IUplateService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Uplate> Get([FromQuery] Model.Requests.UplateSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Uplate GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Uplate Insert([FromBody] Model.Requests.UplateInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Uplate Update(int Id, [FromBody] Model.Requests.UplateInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}