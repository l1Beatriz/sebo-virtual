using AutoMapper;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Profiles;

public class ExchangeProfile : Profile
{
    public ExchangeProfile()
    {
        CreateMap<CreateExchangeDto, Exchange>();
        CreateMap<Exchange, ReadExchangeDto>();
    }
}
