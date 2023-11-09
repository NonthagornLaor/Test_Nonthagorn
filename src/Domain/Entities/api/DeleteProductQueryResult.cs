using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.api
{
    [Keyless]
    public class DeleteProductQueryResult
    {
        public int? count_deleteProduct { get; set; }
    }
}
