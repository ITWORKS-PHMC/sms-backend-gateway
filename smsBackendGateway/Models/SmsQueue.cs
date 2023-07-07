
namespace smsBackendGateway.Models
{
    public class SmsQueue
    {
        //public int contact_id { get; set; }
        public string[] numbers { get; set; }
        public string message { get; set; }

        //public DateOnly Date { get; set; }
        public DateTime date_created { get; set; }

        public SmsQueue(string[] numbers, string message)
        {
            this.numbers = numbers;
            this.message = message; 
        }

        public SmsQueue(){}

    }

  
}
