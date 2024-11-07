using AutoMapper;
using RoleService.Models.Dto;
using RoleService.Models.Entities;

namespace RoleService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
        }
    }
}
