using AutoMapper;
using AutoMapper.Configuration;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;
using UILookUpDropDownLib.Abstractions.DomainUIModels;

namespace UILookUpDropDownLib.SharedUtils.Mappers
{
    public class AutoMapperConfigurator
    {
        public static readonly IMapper Mapper;

        static AutoMapperConfigurator()
        {
            var expression = ConfigureExpression();
            var config = new MapperConfiguration(expression);
            config.AssertConfigurationIsValid();
            Mapper = config.CreateMapper();
        }

        private static MapperConfigurationExpression ConfigureExpression()
        {
            var expression = new MapperConfigurationExpression();
            expression.CreateMap<GlobalGetCounterpartyResponse, GlobalCounterpartyLookUp>();
                //.ForMember(dest => dest.ConfirmedIcon, opt => opt.MapFrom(src => src.State));
            return expression;
        }
    }
}
