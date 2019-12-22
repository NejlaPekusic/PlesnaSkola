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
    public class TreninziController : ControllerBase
    {
        private readonly ITreninziService _service;

        public TreninziController(ITreninziService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Trener")]

        public List<Model.Treninzi> Get([FromQuery] Model.Requests.TreninziSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Treninzi GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Treninzi Insert([FromBody] Model.Requests.TreninziInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Treninzi Update(int Id, [FromBody] Model.Requests.TreninziInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}