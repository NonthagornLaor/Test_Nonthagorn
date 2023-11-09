using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.web
{
    [Keyless]
    public class TestQueryResult
    {
        public int? rule_rank { get; set; }
        //public int? question_rank { get; set; }
        public string? condition_Bypass_fraudscore { get; set; }
        public string? verify_reason { get; set; }
        public string? auto_create_prospect { get; set; } //auto_create_postspect
        public string? response { get; set; }
        public string? period_date { get; set; }
        public string? is_used { get; set; }
    }
}
