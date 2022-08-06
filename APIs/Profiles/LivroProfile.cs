using APIs.Data.DTO;
using APIs.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<LivroDTO, Livro>();
            CreateMap<Livro, ReadLivroDTO>();
            CreateMap<UpDateLivroDTO, Livro>();
        }
    }
}
