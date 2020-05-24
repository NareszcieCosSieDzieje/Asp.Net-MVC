using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Song
    {

        [Key]
        public int Id { set; get; }
        [Required(ErrorMessage = "Name is required!")] 
        [StringLength(100, ErrorMessage = "Maximal length of the name of a song is 100 characters!")] 
        public string Name { set; get; }
        [Required(ErrorMessage = "Artist's name is required!")]
        [StringLength(50, ErrorMessage = "Maximal length of an artist's name is 50 characters!")]
        public string Artist { set; get; }
        public int GenreId { set; get; }

       
    }
}