using ASPNETCOREFIRSTWEB_API_AutoMapper.DTo;
using ASPNETCOREFIRSTWEB_API_AutoMapper.Models;
using AutoMapper;
using System.Runtime.InteropServices;

namespace ASPNETCOREFIRSTWEB_API_AutoMapper.Automapper_Profiler
{
    public class UserProfiller : Profile
    {
        public UserProfiller()
        {
            // Outgoing 
            CreateMap<UserDTO, User>();

            // incoming
            CreateMap<User, UserDTO>();

        }

    }
}
