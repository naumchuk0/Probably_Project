using AccessData.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Probably_Project.Data;
using Probably_Project.Data.Entities;
using Probably_Project.Models;
using System.Dynamic;
using System.Linq;

namespace Probably_Project.Controllers
{
    public class FilmController : Controller
    {
        private readonly MovieDB movie;
        public FilmController(MovieDB movie)
        {
            this.movie = movie;
        }
        private void LoadFilms()
        {
            ViewBag.Films = new SelectList(movie.Films.ToList(),
                                                nameof(Film.Id),
                                                nameof(Film.Title),
                                                nameof(Film.Duration),
                                                nameof(Film.CountryId));
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
        private void LoadComments()
        {
            ViewBag.Comments = new SelectList(movie.Comments.ToList(), nameof(Comment.Id), nameof(Comment.UserName), nameof(Comment.Text), nameof(Comment.FilmId));
        }
        public IActionResult Watch(int id)
        {
            var item = movie.Films.Find(id);

            if (item == null) return RedirectToAction("NotFound");

            LoadGenres();
            LoadCountries();
            LoadComments();

            return View(item);
        }
        [HttpPost]
        public IActionResult AddComment(string comment, int id, string username)
        {
            if (!ModelState.IsValid)
            {
                LoadGenres();
                LoadCountries();
                return RedirectToAction("Watch");
            }

            Comment com = new Comment()
            {
                UserName = username,
                Text = comment,
                FilmId = id,
                Date = DateTime.Now,
            };

            movie.Comments.Add(com);
            movie.SaveChanges();

            return RedirectToAction("Watch", movie.Films.Find(com.FilmId));
        }
        [HttpGet]
        public IActionResult ShowCategory(int id)
        {
            var item = movie.Genres.Find(id);

            LoadFilms();
            LoadCountries();

            return View(item);
        }
        [HttpGet]
        public IActionResult Search(string title)
        {
            dynamic model = new ExpandoObject();

            model.Films = movie.Films.Select(i => i).Where(i => i.Title == title);
            LoadCountries();
            LoadGenres();

            foreach (var item in movie.Films.Select(i => i.Title))
            {
                if (item == title || item.ToUpper() == title || item.ToLower() == title)
                {
                    return View(model);
                }
            }
            return RedirectToAction("NotFound");
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}
