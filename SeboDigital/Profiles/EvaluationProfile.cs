using AutoMapper;
using SeboDigital.Models;

namespace SeboDigital.Profiles;

public class EvaluationProfile : Profile
{
    public EvaluationProfile()
    {
        CreateMap<CreateEvaluationDto, Evaluation>();
        CreateMap<Evaluation, ReadEvaluationDto>();
    }
}
