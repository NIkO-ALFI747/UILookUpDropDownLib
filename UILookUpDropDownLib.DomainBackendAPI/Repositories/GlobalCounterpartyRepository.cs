using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.BackendAPI.Grpc;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Repositories;
using UILookUpDropDownLib.BackendAPI.DIContainer;
using UILookUpDropDownLib.SharedUtils.Mappers;

namespace UILookUpDropDownLib.DomainBackendAPI.Repositories
{
    public class GlobalCounterpartyRepository : IGlobalCounterpartyRepository
    {
        private readonly DictionaryMapper<GlobalGetCounterpartyCollectionRequest> _dictionaryMapper =
            new DictionaryMapper<GlobalGetCounterpartyCollectionRequest>();

        private readonly DataTableMapper<GlobalGetCounterpartyResponse> _dataTableMapper =
            new DataTableMapper<GlobalGetCounterpartyResponse>();

        private static readonly string DataBaseName = "global";

        private IDbService _dbService = BackendAPIAccessor.DbService;

        public async Task<IEnumerable<GlobalGetCounterpartyResponse>> GetAsync(
            GlobalGetCounterpartyCollectionRequest requestParams,
            CancellationToken cancellationToken
            )
        {
            var requestParamsDictionary = _dictionaryMapper.MapToDictionary(requestParams);
            var responseDataTable = await _dbService.CallProcedureAsync(
                $"{DataBaseName}.GetData",
                requestParamsDictionary,
                cancellationToken
                );
            var responseList = _dataTableMapper.MapToList(responseDataTable);
            return responseList;
        }
    }
}
