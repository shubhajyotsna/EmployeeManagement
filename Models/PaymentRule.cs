using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class PaymentRule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RuleName { get; set; }

        // Add any additional properties for the payment rule here
    }
}
