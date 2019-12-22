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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Trener")]
        public List<Model.Korisnici> Get([FromQuery] Model.Requests.KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Trener")]
        public Model.Korisnici GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj")]
        public Model.Korisnici Insert([FromBody] Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj")]
        public Model.Korisnici Update(int Id, [FromBody] Model.Requests.KorisniciUpdateRequest request)
        {
            return _service.Update(Id, request);
        }

        [Authorize]
        [HttpGet("MyProfile")]
        public Model.Korisnici MyProfile()
        {
            return _service.GetMyProfile();
        }


    }
}