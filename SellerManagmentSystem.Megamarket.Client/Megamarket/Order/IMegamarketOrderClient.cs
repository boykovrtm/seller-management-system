using Refit;

namespace SellerManagmentSystem.Megamarket.Client;


public interface IMegamarketOrderClient
{
    [Post("order/search")]
    Task<Search.Response> Search(Search.Request request, CancellationToken cancellationToken);
}