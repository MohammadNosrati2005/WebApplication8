






using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class Product
    {
        [Display(Name = "شماره محصول")]
        public int number { get; set; }
        [Display(Name = "شماره مدرک")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        public string? firstname { get; set; }

    }

}
