using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RoleService.Models.Dto;
using RoleService.Models.Entities;
using RoleService.Persistence;
using RoleService.Services.Contracts;
using SharedUtilities.CustomExceptions;

namespace RoleService.Services
{
    public class RolesService : IRolesService
    {
        private readonly RoleDbContext _dbContext;
        private readonly IMapper _mapper;

        public RolesService(RoleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<RoleResponseDto> CreateRole(RoleRequestDto roleDto)
        {
            var role = _mapper.Map<Role>(roleDto);

            _dbContext.Roles.Add(role);

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<RoleResponseDto>(role);
        }

        public async Task<IEnumerable<RoleResponseDto>> GetRoles()
        {
            var roles = await _dbContext.Roles.ToListAsync();

            return _mapper.Map<IEnumerable<RoleResponseDto>>(roles);
        }

        public async Task<RoleResponseDto> GetRole(int roleId)
        {
            var role = await GetRoleOrThrowNotFoundException(roleId);

            return _mapper.Map<RoleResponseDto>(role);
        }

        public async Task<RoleResponseDto> UpdateRole(int roleId, RoleRequestDto roleRequestDto)
        {
            var role = await GetRoleOrThrowNotFoundException(roleId);

            _mapper.Map(roleRequestDto, role);

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<RoleResponseDto>(role);
        }

        public async Task DeleteRole(int roleId)
        {
            var role = await GetRoleOrThrowNotFoundException(roleId);

            _dbContext.Roles.Remove(role);

            await _dbContext.SaveChangesAsync();
        }

        private async Task<Role> GetRoleOrThrowNotFoundException(int roleId)
        {
            var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.Id == roleId);

            if (role == null)
                throw new NotFoundException("Role not found");

            return role;
        }
    }
}
