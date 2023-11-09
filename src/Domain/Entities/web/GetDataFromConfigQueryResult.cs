using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities.web
{
    [Keyless]
    public class GetDataFromConfigQueryResult
    {
        public string? rule_id { set; get; }
        public string? rule_rank { set; get; }
        public string? effective_start_date { set; get; }
        public string? effective_end_date { set; get; }
        public string? enable_status { set; get; }
        public string? question_group_id { set; get; }
        public string? question_group_name { set; get; }
        public string? Question_id { set; get; }
        public string? question_name { set; get; }
        public string? operation_id { set; get; }
        public string? operation_value { set; get; }
        public string? answer_id { set; get; }
        public string? answer_option_id { set; get; }
        public string? answer_option_name { set; get; }
        public string? answer_text_value { set; get; }
        public string? notify_popup { set; get; }
        public string? notify_message { set; get; }
        public string? flag_go_nogo { set; get; }
        public string? auto_create_prospect { set; get; }
        public string? verify_reason { set; get; }
        public string? active_fraud { set; get; }
        public string? StatusCode { set; get; } //= null!;
        public string? StatusMessage { set; get; } //= null!;
        //public string? fraud_score_config { set; get; }
        public int? fraud_score_config { set; get; }
        public string? fraud_score_operation { set; get; }
        public string? fraud_type { set; get; }
    }
}
