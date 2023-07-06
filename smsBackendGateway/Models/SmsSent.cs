namespace smsBackendGateway.Models
{
    public class SmsSent
    {
        public int contact_id { get; set; }
        public int mobile_no { get; set; }
        public string sms_message { get; set;}
        public DateTime date_created { get; set; }
    }
}
