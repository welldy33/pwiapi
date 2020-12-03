using AutoMapper;
using pwiapi.Models;
using pwiapi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pwiapi.Profiles
{
    public class LinesProfile:Profile
    {
        public LinesProfile() {
            //Source->Target
            CreateMap<Line,LineReadDtos>();
            CreateMap<LineCreateDtos, Line>();
            CreateMap<LineUpdateDtos, Line>();
        }
        

    }
}
