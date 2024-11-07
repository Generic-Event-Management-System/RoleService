using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleService.Models.Dto;
using RoleService.Services.Contracts;

namespace RoleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleRequestDto roleDto)
        {
            return Ok(await _rolesService.CreateRole(roleDto));
        }
    }
}
