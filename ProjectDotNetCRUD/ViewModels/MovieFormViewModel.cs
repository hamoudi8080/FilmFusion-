using ProjectDotNetCRUD.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectDotNetCRUD.ViewModels
{
    public class MovieFormViewModel
    {

        [Required, StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }
        [Range(1,10)]
        public double Rate { get; set; }

        [Required, StringLength(2500)]
        public string Storeline { get; set; }


        [Display(Name = "Select poster...")]
        public byte[] Poster { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { set; get; }
    }
}
