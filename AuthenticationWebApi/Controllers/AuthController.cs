﻿using AuthenticationWebApi.Models.Dtos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        

        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(UserDto requests)
        {
            var response = await _authService.RegisterUser(requests);
            return Ok(response);
        }
    }
}
