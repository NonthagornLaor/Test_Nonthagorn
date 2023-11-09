using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.api
{
    [Keyless]
    public class AddProductQueryResult
    {
        public int? count_addProduct { get; set; }
    }
}
