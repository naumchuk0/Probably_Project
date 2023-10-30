using AccessData.Data.Entities;

namespace Probably_Project.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Img { get; set; }
        public string? Video { get; set; }
        public int Duration { get; set; }
        public int GraduationYear { get; set; }
        public int Views { get; set; }
        public int CountryId { get; set; }
        public int GenreId { get; set; }
        public Country? Country { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
