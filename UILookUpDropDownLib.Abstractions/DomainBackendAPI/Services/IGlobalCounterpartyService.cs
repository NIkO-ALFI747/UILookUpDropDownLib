using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;
using UILookUpDropDownLib.Abstractions.DomainUIModels;

namespace UILookUpDropDownLib.Abstractions.DomainBackendAPI.Services
{
    public interface IGlobalCounterpartyService
    {
        Task<IEnumerable<GlobalCounterpartyLookUp>> GetAsync(
            GlobalGetCounterpartyCollectionRequest requestParams,
            CancellationToken cancellationToken
            );
    }
}
