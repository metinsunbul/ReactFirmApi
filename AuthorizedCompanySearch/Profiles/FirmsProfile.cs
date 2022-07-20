using AuthorizedCompanySearch.Dtos;
using AuthorizedCompanySearch.Models;
using AutoMapper;

namespace AuthorizedCompanySearch.Profiles
{
    public class FirmsProfile : Profile
    {
        public FirmsProfile()
        {
            //source -> destination
            CreateMap<FirmModel, FirmReadDtos>();

        }
    }
}
