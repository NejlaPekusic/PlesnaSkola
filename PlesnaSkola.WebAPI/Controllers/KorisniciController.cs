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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery] Model.Requests.KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public Model.Korisnici GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Korisnici Insert([FromBody] Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        public Model.Korisnici Update(int Id, [FromBody] Model.Requests.KorisniciUpdateRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}