﻿using RoleService.Models.Dto;
using RoleService.Models.Entities;

namespace RoleService.Services.Contracts
{
    public interface IRolesService
    {
        Task<RoleResponseDto> CreateRole(RoleRequestDto roleDto);
        Task<IEnumerable<RoleResponseDto>> GetRoles();
        Task<RoleResponseDto> GetRole(int roleId);
        Task<RoleResponseDto> UpdateRole(int roleId, RoleRequestDto roleRequestDto);
        Task DeleteRole(int roleId);
    }
}
