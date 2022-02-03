using AutoMapper;
using Data.DTOs;
using Models.Entities;
using Models.Enums;

namespace Data.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AppUser, AppUserDTO>();

            CreateMap<Device, DeviceDTO>()
                .ForMember(d => d.Type, opt => opt.MapFrom(s => Enum.GetName(typeof(DeviceType), s.TypeId)));

            CreateMap<Device, DeviceDetailsDTO>()
                .ForMember(d => d.Type, opt => opt.MapFrom(s => Enum.GetName(typeof(DeviceType), s.TypeId))).ReverseMap();
        }
    }
}