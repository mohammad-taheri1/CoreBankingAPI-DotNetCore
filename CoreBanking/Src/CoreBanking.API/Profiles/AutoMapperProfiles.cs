﻿using AutoMapper;
using CoreBanking.API.Models;
using CoreBanking.API.Models.DTOs;

namespace CoreBanking.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterNewAccountDTO, Account>();
            CreateMap<UpdateAccountDTO, Account>();
            CreateMap<Account, GetAccountDTO>();
            CreateMap<TransactionRequestDTO, Transaction>();
        }
    }
}
