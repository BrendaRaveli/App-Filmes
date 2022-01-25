using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [StringLength(60, MinimumLength = 3)]
        //[/*Required]*/
        public string Title { get; set; }

        [Display(Name = "Data de lançamento"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
       
        public DateTime ReleaseDate { get; set; }


        //[Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"),StringLength(30)]
        [Display(Name = "Genero")]
        public string Genre { get; set; }

        [Display(Name = "Preço")]
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Display(Name = "Avaliação")]
        [/*RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"),*/ StringLength(5)]
        //[Required]
        public string Rating { get; set; }
    }
}