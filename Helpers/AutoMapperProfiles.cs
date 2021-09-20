using AutoMapper;
using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Requests;
namespace JAP_Task_1_MoviesApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            //CreateMap<UserRegisterRequest, UserEntity>();
            CreateMap<VideoEntity, MovieDto>();
        }
    }
}
