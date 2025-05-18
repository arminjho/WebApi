﻿using AutoMapper;
using WebApi.Dtos.Character;
using WebApi.Dtos.Fight;
using WebApi.Dtos.Skill;
using WebApi.Dtos.Weapon;

namespace WebApi
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();
        }
    }
}
