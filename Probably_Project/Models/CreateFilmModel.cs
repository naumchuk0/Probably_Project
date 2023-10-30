using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Probably_Project.Models
{
    public class CreateFilmModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile? Image { get; set; }
        public IFormFile? VideoMod { get; set; }
        public int Duration { get; set; }
        public int Release { get; set; }
        public int Views { get; set; }
        public int CountryId { get; set; }
        public int GenreId { get; set; }
    }
}
