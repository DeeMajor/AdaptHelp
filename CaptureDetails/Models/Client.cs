using System.ComponentModel.DataAnnotations;

namespace CaptureDetails.Models
{
    public class Client
    {
        public string clientName { get; set; }
        public string dateRegistered { get; set; }
        public int numberOfUsers { get; set; }
        public string location { get; set; }
    }
}
