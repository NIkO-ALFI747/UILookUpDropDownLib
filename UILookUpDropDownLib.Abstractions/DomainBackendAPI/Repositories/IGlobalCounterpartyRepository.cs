using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;

namespace UILookUpDropDownLib.Abstractions.DomainBackendAPI.Repositories
{
    public interface IGlobalCounterpartyRepository
    {
        Task<IEnumerable<GlobalGetCounterpartyResponse>> GetAsync(
            GlobalGetCounterpartyCollectionRequest requestParams,
            CancellationToken cancellationToken
            );
    }
}
