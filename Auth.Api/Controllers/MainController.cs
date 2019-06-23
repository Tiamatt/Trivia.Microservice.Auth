using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.Contracts;
using ApiModels = Auth.Contracts.ApiModels;
using Auth.Api.Helpers;
using Auth.Contracts.Helpers;
using Auth.Contracts.ApiModels;

namespace Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMainHelper _mainHelper;

        public MainController(IMainHelper mainHelper)
        {
            _mainHelper = mainHelper;
        }


        [HttpGet("/api/main/GetLoginTypes/{isActive}")]
        public ActionResult<GetLoginTypesResponse> GetLoginTypes(bool? isActive)
        {
            try
            {
                var result = _mainHelper.GetLoginTypes(isActive);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
