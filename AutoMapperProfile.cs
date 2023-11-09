using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Mapping Character -> GetCharacterDto
            CreateMap<Character, GetCharacterDto>();
            //Mapping AddCharacterDto -> Character
            CreateMap<AddCharacterDto, Character>();
        }
    }
}