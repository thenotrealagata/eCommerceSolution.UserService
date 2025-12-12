using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService) {
            _usersService = usersService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserById(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                return BadRequest("Invalid Id value!");
            }

            UserResponse? user = await _usersService.GetUserById(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
