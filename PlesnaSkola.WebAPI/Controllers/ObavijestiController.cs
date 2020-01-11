using System;
using System.Collections.Generic;
using System.IO;
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
    public class ObavijestiController : ControllerBase
    {
        private readonly IObavijestiService _service;

        public ObavijestiController(IObavijestiService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Voditelj,Trener,Asistent,Plesac,Roditelj")]

        public List<Model.Obavijesti> Get([FromQuery] Model.Requests.ObavijestiSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet("DownloadAttachment/{id}")]
        [AllowAnonymous]
        public IActionResult DownloadAttachment(int id)
        {
            Model.Obavijesti obavijest = _service.GetById(id);

            if (obavijest == null)
                return NotFound();

            Stream stream = new MemoryStream(obavijest.Prilog);
            return File(stream, "application/octet-stream", obavijest.PrilogFileName);

        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Voditelj,Trener,Asistent,Plesac,Roditelj")]

        public Model.Obavijesti GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize(Roles = "Voditelj,Trener,Asistent")]

        public Model.Obavijesti Insert([FromBody] Model.Requests.ObavijestiInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{Id}")]
        [Authorize(Roles = "Voditelj,Trener,Asistent")]

        public Model.Obavijesti Update(int Id, [FromBody] Model.Requests.ObavijestiInsertRequest request)
        {
            return _service.Update(Id, request);
        }

    }
}