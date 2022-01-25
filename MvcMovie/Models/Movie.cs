using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [Display(Name = "Genero")]
        public string Genre { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Avaliação")]
        public string Rating { get; set; }
    }
}