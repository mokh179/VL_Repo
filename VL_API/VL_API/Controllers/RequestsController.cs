using API.core.Interface;
using API.core.Models;
using API.core.Vmodels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IBase<Request> _requests;
        public RequestsController(IBase<Request> requsets)
        {
            _requests = requsets;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return  Ok(await _requests.GetAll());
        }
        [HttpPost("Add")]
        public IActionResult Add(RequestVM rqVM)
        {
           
            if (!ModelState.IsValid)
                return BadRequest();
           
            var Res = _requests.Add(rqVM);
            if (Res.Status != 1)
                return BadRequest(Res);
            return Ok(Res);
        }
    }
}
