using AutoMapper;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Profiles;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<Book, ReadBookDto>();
    }
}
