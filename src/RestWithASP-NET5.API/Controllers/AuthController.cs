﻿using Microsoft.AspNetCore.Mvc;
using RestWithASP_NET5.API.Business;
using RestWithASP_NET5.API.Data.VO;

namespace RestWithASP_NET5.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UserVO user) 
        {
            if (user == null) return BadRequest("Ivalid client request");
            var token = _loginBusiness.ValidateCredentials(user);
            if (token == null) return Unauthorized(); 
            return Ok(token);
        }
    }
}
