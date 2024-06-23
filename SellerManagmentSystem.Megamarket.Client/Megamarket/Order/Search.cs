using System.Text.Json.Serialization;

namespace SellerManagmentSystem.Megamarket.Client;

public sealed record Search
{
    public sealed record Request
    {
        public sealed record Data
        {
            [JsonPropertyName("token")] public string Token { get; init; }
        }

        public sealed record Meta
        {

        }
    }


    public sealed record Response
        {
            
        }
}