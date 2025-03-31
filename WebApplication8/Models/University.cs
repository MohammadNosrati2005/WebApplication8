using Microsoft.EntityFrameworkCore;
namespace WebApplication8.Models
{
    public class University
    {
        public int Id { get; set; }
        public required string Name {  get; set; }
        public required string NameEnglish { get; set; }
    }
}
