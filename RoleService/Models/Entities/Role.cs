namespace RoleService.Models.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required ICollection<UserRole> UserRoles { get; set; }
    }
}
