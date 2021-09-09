using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfiles : Profile
    {
        public FilmeProfiles()
        {
            CreateMap<CreateFilmeDto, Filmes>();
            CreateMap<UpdateFilmeDto, Filmes>();
            CreateMap<Filmes, ReadFilmeDto >();
        }
    }
}
