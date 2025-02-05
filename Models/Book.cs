using System.ComponentModel.DataAnnotations;



namespace LibraryManagementSystem.Models
{
    // Kütüphane yönetim sistemindeki bir kitabı temsil eder.
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        public int Year { get; set; }

        public string? Category { get; set; }
    }
}
