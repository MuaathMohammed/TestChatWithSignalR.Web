using AutoMapper;
using TestChatWithSignalR.Web.Models;
using TestChatWithSignalR.Web.ViewModels;

namespace TestChatWithSignalR.Web.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dst => dst.UserName, opt => opt.MapFrom(x => x.UserName));

            CreateMap<UserViewModel, ApplicationUser>();
        }
    }
}
