﻿namespace RoleService.Models.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public required int UserId { get; set; }
    }
}
