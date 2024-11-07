using AutoMapper;
using RoleService.Models.Dto;
using RoleService.Models.Entities;

namespace RoleService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Role, RoleRequestDto>();
            CreateMap<RoleRequestDto, Role>();
            CreateMap<RoleResponseDto, Role>();
            CreateMap<Role, RoleResponseDto>();
        }
    }
}
