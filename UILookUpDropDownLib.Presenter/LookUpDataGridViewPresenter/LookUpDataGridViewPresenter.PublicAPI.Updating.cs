using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Contracts;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Services;
using UILookUpDropDownLib.Abstractions.DomainUIModels;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        IGlobalCounterpartyService GlobalCounterpartyService { get; set; }

        private CancellationTokenSource _searchCts;

        public async Task<IEnumerable<GlobalCounterpartyLookUp>> GetLookUpCollectionAsync(
            GlobalGetCounterpartyCollectionRequest requestParams
            )
        {
            _searchCts?.Cancel();
            _searchCts?.Dispose();
            _searchCts = new CancellationTokenSource();
            var token = _searchCts.Token;
            try
            {
                token.ThrowIfCancellationRequested();
                var dataCollection =
                    await GlobalCounterpartyService.GetAsync(
                        requestParams,
                        token
                        );
                token.ThrowIfCancellationRequested();
                return dataCollection;
            }
            catch (OperationCanceledException)
            {
                throw;
            }
        }

        public async Task UpdateLookUpDataGrid(
            GlobalGetCounterpartyCollectionRequest requestParams
            )
        {
            var lookUpDataCollection = await GetLookUpCollectionAsync(requestParams);
            //View.UpdateGrid(dataCollection);
        }
    }
}
