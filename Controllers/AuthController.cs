using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApi.Data;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthRepository authRepo, ILogger<AuthController> logger)
        {
            _authRepo = authRepo;
            _logger = logger;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
            );
            if (!response.Success)
            {
                _logger.LogError("Error ocurred with register method");
                return StatusCode(500, response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);
            if (!response.Success)
            {
                _logger.LogError("Error ocurred with login method");
                return StatusCode(500, response);
            }
            return Ok(response);
        }

        

    }
}
