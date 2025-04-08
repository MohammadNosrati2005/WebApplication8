using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Design;

namespace InputApp.Models
{
    public class InputData
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Input")]
        public required string FirstInput { get; set; }

        [Required]
        [Display(Name = "Second Input")]
        public required string SecondInput { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

