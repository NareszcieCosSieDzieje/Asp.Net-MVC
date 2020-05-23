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
        public string Name { set; get; }
        public string Artist { set; get; }
        public int GenreId { set; get; }

       
    }
}