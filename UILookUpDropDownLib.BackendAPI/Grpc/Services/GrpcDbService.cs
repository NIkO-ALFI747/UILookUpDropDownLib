using AutoMapper;
using Legacy.GrpcContracts;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.BackendAPI.Grpc;
using UILookUpDropDownLib.BackendAPI.Contracts;
using UILookUpDropDownLib.BackendAPI.Grpc.Infrastructure;
using UILookUpDropDownLib.BackendAPI.Mappers.Grpc;
using static Legacy.GrpcContracts.LegacyDbService;

namespace UILookUpDropDownLib.BackendAPI.Grpc.Services
{
    public class GrpcDbService : IDbService
    {
        private LegacyDbServiceClient GrpcClient { get; }

        private PackedObjectMapper PackedObjectMapper { get; } = new PackedObjectMapper();

        private UserInfoRequest UserInfo { get; } = new UserInfoRequest() { UserName = "", UserId = -1 };

        private IMapper Mapper { get; }

        public GrpcDbService(GrpcConnectionManager connectionManager, IMapper mapper)
        {
            GrpcClient = new LegacyDbServiceClient(connectionManager.GetInvoker());
            Mapper = mapper;
        }

        public DataTable CallProcedure(
            string procedureName, 
            Dictionary<string, object> requestParams
            )
        {
            var request = CreateRequest(procedureName, requestParams);
            var response = GrpcClient.CallProcedureDT(request);
            return ProcessResponse(response);
        }

        public async Task<DataTable> CallProcedureAsync(
            string procedureName,
            Dictionary<string, object> requestParams,
            CancellationToken cancellationToken
            )
        {
            var request = CreateRequest(procedureName, requestParams);
            var response = await GrpcClient.CallProcedureDTAsync(
                request, null, null, cancellationToken
                );
            return ProcessResponse(response);
        }

        private CallProcedureDTRequest CreateRequest(
            string procedureName,
            Dictionary<string, object> requestParams
            )
        {
            var request = new CallProcedureDTRequest
            {
                ProcName = procedureName,
                User = Mapper.Map<UserInfo>(UserInfo)
            };
            request.Args.MergeFrom(PackedObjectMapper.Map(requestParams));
            return request;
        }

        private DataTable ProcessResponse(CallProcedureDTResponse response)
        {
            if (response == null) return null;
            return (DataTable)PackedObjectMapper.Map(response.PackedDataTable);
        }
    }
}
