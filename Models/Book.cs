using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string ? Title { get; set; }
        [MaxLength (300)]
        public string ? Description { get; set; }
        [MaxLength(200)]
        public string? Author { get; set; }
        [MaxLength]
        public byte [] Image { get; set; }
    }
}
