using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace DuvarAPI
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterDTO, User>();
            CreateMap<AddEntryDTO, Entry>();
        }
    }
}
