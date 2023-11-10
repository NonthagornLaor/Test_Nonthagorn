namespace TestApi.Models
{
    public class responseData
    {
    }
    public class statusResponse
    {
        public int? statusCode { get; set; }
        public string? statusMessage { get; set; }
    }
    public class GetData 
    {
        public statusResponse status { get; set; }
        public List<GetResponse>? Data { get; set; }
    }
    public class GetResponse
    {
        public int? product_id { get; set; }
        public string? product_name { get; set; }
        public string? product_price { get; set; }
        public string? product_decription { get; set; }
        public string? create_date { get; set; }
        public string? last_update_date { get; set; }
    }   
}
