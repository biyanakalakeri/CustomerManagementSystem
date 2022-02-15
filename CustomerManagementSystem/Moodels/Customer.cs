using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.Moodels
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
