using RoleService.Models.Entities;

namespace RoleService.Models.Dto
{
    public class RoleResponseDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
