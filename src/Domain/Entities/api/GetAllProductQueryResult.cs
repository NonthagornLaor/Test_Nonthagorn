using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities.api
{
    [Keyless]
    public class GetAllProductQueryResult
    {
        public int? product_id { get; set; }
        public string? product_name { get; set; }
        public string? product_price { get; set; }
        public string? product_decription { get; set; }
        public string? create_date { get; set; }
        public string? last_update_date { get; set; }
    }
}
