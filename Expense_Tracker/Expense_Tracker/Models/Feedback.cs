using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Feedback
    {
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Message { get; set; }
    }
}
