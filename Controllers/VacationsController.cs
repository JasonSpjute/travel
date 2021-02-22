using Microsoft.AspNetCore.Mvc;
using travel.Services;
using travel.Models;
using System.Collections.Generic;
using System;

namespace travel.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class VacationsController : ControllerBase
    {
        private readonly VacationsService _serv;
        public VacationsController(VacationsService serv)
        {
            _serv = serv;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Vacation>> GetAll()
        {
            try
            {
                return Ok(_serv.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}