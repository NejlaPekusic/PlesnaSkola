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
    public class MuzikaController : ControllerBase
    {
        private readonly IMuzikaService _service;

        public MuzikaController(IMuzikaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Trener")]

        public List<Model.Muzika> Get([FromQuery] Model.Requests.MuzikaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Muzika GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Muzika Insert([FromBody] Model.Requests.MuzikaInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj,Trener")]

        public Model.Muzika Update(int Id, [FromBody] Model.Requests.MuzikaInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}