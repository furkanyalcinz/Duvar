using Application.DTO;
using AutoMapper;
using Domain.Common.ReturnTypes;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace DuvarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<Result>> AddUser(UserRegisterDTO userRegisterDTO)
        {
            var user = _mapper.Map<User>(userRegisterDTO);
            await _userService.Register(user);
            
            return Ok();
        }
    }
}
