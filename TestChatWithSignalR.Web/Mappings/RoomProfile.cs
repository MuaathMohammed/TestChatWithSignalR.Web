using AutoMapper;
using TestChatWithSignalR.Web.Models;
using TestChatWithSignalR.Web.ViewModels;

namespace TestChatWithSignalR.Web.Mappings
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomViewModel>()
                .ForMember(dst => dst.Admin, opt => opt.MapFrom(x => x.Admin.UserName));

            CreateMap<RoomViewModel, Room>();
        }
    }
}
