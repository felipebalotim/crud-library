using System;
using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="O título do livro é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Título")]
        [StringLength(64,MinimumLength=3)]
        public string Title { get; set; }

        [Required(ErrorMessage="O nome do autor é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Autor")]
        [StringLength(64,MinimumLength=3)]
        public string Author { get; set; }

        [Required(ErrorMessage="O número de páginas é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Nº. de páginas")]
        [Range(1, 9999)]
        public int Page { get; set; }
    }
}


	