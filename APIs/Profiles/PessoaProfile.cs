using APIs.Data.DTO;
using APIs.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<PessoaDTO, Pessoas>();
            CreateMap<Pessoas, ReadPessoaDTO>();
            CreateMap<UpDatePessoaDTO, Pessoas>();
        }
    }
}
