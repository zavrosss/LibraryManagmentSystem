using System.ComponentModel.DataAnnotations;
namespace LibraryManagmentSystem.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? PublicationDate { get; set; }
    }
}
