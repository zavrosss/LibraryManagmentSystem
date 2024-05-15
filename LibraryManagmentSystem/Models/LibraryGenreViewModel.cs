using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace LibraryManagmentSystem.Models
{
    public class LibraryGenreViewModel
    {
        public List<Library>? Libraries { get; set; }
        public SelectList? Genres { get; set; }
        public string LibraryGenre { get; set; }
        public string? searchString { get; set; }
    }
}
