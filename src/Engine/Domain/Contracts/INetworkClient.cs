using CosmosWallet.Engine.Domain.Models;

namespace CosmosWallet.Engine.Domain.Contracts;

public interface INetworkClient
{
    string NetworkId { get; }

    Task<long> GetLatestBlockNumberAsync(CancellationToken cancellationToken);

    Task<decimal> GetNativeBalanceAsync(string address, CancellationToken cancellationToken);

    Task<IReadOnlyList<TransactionRecord>> GetTransactionsAsync(string address, long fromBlock, long toBlock, CancellationToken cancellationToken);

    Task<bool> IsEndpointHealthyAsync(CancellationToken cancellationToken);
}
