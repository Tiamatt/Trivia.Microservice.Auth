using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.Contracts;
using ApiModels = Auth.Contracts.ApiModels;
using Auth.Api.Managers;
using Auth.Contracts.Managers;
using Auth.Contracts.ApiModels;

namespace Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMainManager _mainManager;

        public MainController(IMainManager mainManager)
        {
            _mainManager = mainManager;
        }


        [HttpGet("/api/main/GetLoginTypes/{isActive}")]
        public ActionResult<GetLoginTypesResponse> GetLoginTypes(bool? isActive)
        {
            try
            {
                var result = _mainManager.GetLoginTypes(isActive);
                return Ok(result);
            }
            catch (Exception ex)
            {
                //TODO kali - log error
                return StatusCode(500, ex);
            }
        }

    }
}
