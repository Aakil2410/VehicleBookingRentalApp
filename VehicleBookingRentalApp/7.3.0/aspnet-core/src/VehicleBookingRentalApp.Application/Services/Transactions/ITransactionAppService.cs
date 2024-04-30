using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Services.Transactions.Dto;

namespace VehicleBookingRentalApp.Services.Transactions
{
    public interface ITransactionAppService : IApplicationService
    {
        Task<TransactionDto> CreateAsync(TransactionDto input);

        Task<TransactionDto> GetAsync(Guid id);

        Task<List<TransactionDto>> GetAllAsync();

        Task<TransactionDto> UpdateAsync(TransactionDto input);

        Task DeleteAsync(Guid id);

    }
}
