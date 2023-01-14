using AutoMapper;
using dotnet_rbg.Dtos.Character;
using dotnet_rbg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rbg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>().ReverseMap();
            CreateMap<AddCharacterDto, Character>().ReverseMap();
            CreateMap<UpdateCharacterDto, Character>().ReverseMap();
        }
    }
}
