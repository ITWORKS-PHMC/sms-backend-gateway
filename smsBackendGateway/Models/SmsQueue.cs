
namespace smsBackendGateway.Models
{
    public class SmsQueue
    {
        //public int contact_id { get; set; }
        public string[] numbers { get; set; }
        public string message { get; set; }
        public DateOnly Date { get; set; }

        public SmsQueue(string[] numbers, string message, DateOnly date)
        {
            this.numbers = numbers;
            this.message = message; 
            this.Date = date;

       
        }

        public SmsQueue(){}

    }

  
}
