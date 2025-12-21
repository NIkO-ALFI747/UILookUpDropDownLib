using AutoMapper;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Repositories;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Services;
using UILookUpDropDownLib.Abstractions.DomainUIModels;
using UILookUpDropDownLib.SharedUtils.Mappers;

namespace UILookUpDropDownLib.DomainBackendAPI.Services
{
    public class GlobalCounterpartyService : IGlobalCounterpartyService
    {
        private IGlobalCounterpartyRepository Repository { get; set; }

        private IMapper Mapper { get; set; }

        public GlobalCounterpartyService(IGlobalCounterpartyRepository repository)
        {
            Mapper = AutoMapperConfigurator.Mapper;
            Repository = repository;
        }

        public async Task<IEnumerable<GlobalCounterpartyLookUp>> GetAsync(
            GlobalGetCounterpartyCollectionRequest requestParams,
            CancellationToken cancellationToken
            )
        {
            var dataCollectionResponse = await Repository.GetAsync(requestParams, cancellationToken);
            var userControlCollection = Mapper.Map<IEnumerable<GlobalCounterpartyLookUp>>(
                dataCollectionResponse
                );
            return userControlCollection;
        }
    }
}
