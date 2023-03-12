﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectDotNetCRUD.Models;
using ProjectDotNetCRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProjectDotNetCRUD.Controllers
{
    public class MoviesController : Controller
    {

        private readonly ApplicationDbContext _context;

        private new List<string> _allowedExtenstions = new List<string> { ".jpg", ".png" };

        public MoviesController(ApplicationDbContext context)
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //MY Action is index i retrive all data from database and 
            var movies = await _context.Movies.ToListAsync();
           // then it sends them to the view in shared.Index
            return View(movies);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync()
            };
            return View(viewModel);
        }


        //The[ValidateAntiForgeryToken] attribute is a security measurethat helps prevent Cross-Site Request Forgery(CSRF) attacks.
        //without the user's knowledge or consent.
        //The attacker can exploit the user's authenticated session to perform unauthorized actions on behalf of the user.
        //To prevent CSRF attacks, the[ValidateAntiForgeryToken] attribute requires a unique token to be sent with each form submission.
        //This token is generated by the server and is added to the form as a hidden input field.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                return View(model);
            }

            var files = Request.Form.Files;
            if (!files.Any())
            {
                model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Please select movie poster!");
                return View("MovieForm", model);
            }

            var poster = files.FirstOrDefault();

            if (!_allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
            {
                model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Only .PNG, .JPG images are allowed!");
                return View( model);
            }

            if(poster.Length > 1048576)
            {
                model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Poster cannot be more than 1 mb");
                return View(model);

            }

            //a new MemoryStream object called dataStream is created using the new keyword.
            //This object will be used to temporarily hold the contents of a file that the user has uploaded. 
           //read or write data in memory, and it's often used when you want to manipulate data in memory without writing it to disk

            using var dataStream = new MemoryStream();

            //we get the content which is a file or img and deliver to the destination which is dataStream
            await poster.CopyToAsync(dataStream);


            var movie = new Movie
            {
                Title = model.Title,
                GenreId = model.GenreId,
                Year = model.Year,
                Rate = model.Rate,
                Storeline = model.Storeline,
                //The ToArray() method is a method provided by the MemoryStream class that returns the entire contents of the stream as an array of bytes.
                //n this case,dataStream.ToArray() is returning an array of bytes containing the file data that was uploaded by the user
                Poster = dataStream.ToArray()

            };

            _context.Movies.Add(movie);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
    }
}
