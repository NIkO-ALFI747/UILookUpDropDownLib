using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace UILookUpDropDownLib.Abstractions.BackendAPI.Grpc
{
    public interface IDbService
    {
        DataTable CallProcedure(
            string procedureName,
            Dictionary<string, object> requestParams
            );

        Task<DataTable> CallProcedureAsync(
            string procedureName,
            Dictionary<string, object> requestParams,
            CancellationToken cancellationToken
            );
    }
}
