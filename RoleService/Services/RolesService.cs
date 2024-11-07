using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RoleService.Models.Dto;
using RoleService.Models.Entities;
using RoleService.Persistence;
using RoleService.Services.Contracts;

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
    }
}
