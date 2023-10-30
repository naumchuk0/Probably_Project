using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Scripting;
using NuGet.Protocol;
using Probably_Project.Data;
using Probably_Project.Data.Entities;
using Probably_Project.Models;
using System.Data;
using System.Diagnostics;
using System.Dynamic;

namespace Probably_Project.Controllers
{
    public class HomeController : Controller
    {
        static int limit = 3;
        private readonly MovieDB movie;
        public HomeController(MovieDB movie)
        {
            this.movie = movie;
        }
        private void LoadCountries()
        {
            ViewBag.Countries = new SelectList(movie.Countries.ToList(),
                                                nameof(Country.Id),
                                                nameof(Country.Name));
        }
        private void LoadGenres()
        {
            ViewBag.Genres = new SelectList(movie.Genres.ToList(),
                                                nameof(Genre.Id),
                                                nameof(Genre.Name));
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = movie.Films.Select(i => i).Take(limit).ToList();
            var genres = movie.Genres.ToList();

            dynamic model = new ExpandoObject();

            model.Film = data;
            model.Genre = genres;
            LoadCountries();

            return View(model);
        }
        public IActionResult Add()
        {
            limit += 3;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult LoadUp()
        {
            LoadGenres();
            LoadCountries();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoadUp(CreateFilmModel film)
        {
            if (!ModelState.IsValid)
            {
                LoadGenres();
                LoadCountries();
                return View(film);
            }

            Film newFilm = new()
            {
                Title = film.Title,
                Description = film.Description,
                Duration = film.Duration,
                CountryId = film.CountryId,
                GenreId = film.GenreId,
                GraduationYear = film.Release
            };

            if (film.Image != null && film.Image.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "File/images/", film.Image.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    film.Image.CopyTo(stream);
                }
                newFilm.Img = film.Image.FileName;
            }
            
            if (film.VideoMod != null && film.VideoMod.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "File/movies/", film.VideoMod.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    film.VideoMod.CopyTo(stream);
                }
                newFilm.Video = film.VideoMod.FileName;
            }

            movie.Films.Add(newFilm);
            await movie.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}