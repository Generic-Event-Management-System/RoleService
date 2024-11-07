using RoleService.Models.Entities;

namespace RoleService.Models.Dto
{
    public class RoleDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
