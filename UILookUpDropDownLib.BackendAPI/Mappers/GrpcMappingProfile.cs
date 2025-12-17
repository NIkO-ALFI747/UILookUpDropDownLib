using AutoMapper;
using UILookUpDropDownLib.BackendAPI.Contracts;
using UserInfoGrpc = Legacy.GrpcContracts.UserInfo;

namespace UILookUpDropDownLib.BackendAPI.Mappers
{
    public class GrpcMappingProfile : Profile
    {
        public GrpcMappingProfile()
        {
            CreateMap<UserInfoRequest, UserInfoGrpc>();
        }
    }
}
