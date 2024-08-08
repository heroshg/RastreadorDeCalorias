using AutoMapper;
using RastreadorDeCalorias.API.Entities;
using RastreadorDeCalorias.API.Models.InputModels;
using RastreadorDeCalorias.API.Models.ViewModels;

namespace RastreadorDeCalorias.API.Mappers
{
    public class CalorieTrackerProfile : Profile
    {
        public CalorieTrackerProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();

            CreateMap<UserInputModel, User>();

            CreateMap<Activity, ActivityViewModel>();
            CreateMap<ActivityViewModel, Activity>();
            
            CreateMap<ActivityInputModel, Activity>();

        }
    }
}
