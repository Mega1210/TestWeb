﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;
using TestWeb.ViewModels;

namespace TestWeb.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie =new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1" },
                new Customer {Name="Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
                   return View(viewModel);
            //return Content("Hello");
            //  return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }

        public ActionResult ListMovies()
        {
            var list = new List<Movie>
            {
            new Movie { Name = "Shrek!", Id = 1 },
            new Movie { Name = "Wall-E", Id = 2 }
            };

            var listMovie = new ListMovies
            {
                listOfMovies = list
            };

            return View(listMovie);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";
            
            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}