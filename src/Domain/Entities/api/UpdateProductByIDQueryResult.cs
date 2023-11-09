using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.api
{
    [Keyless]
    public class UpdateProductByIDQueryResult
    {
        public int? count_updateProductById { get; set; }
    }
}
