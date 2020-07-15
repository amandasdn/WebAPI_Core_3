using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título da Categoria")]
        [Required(ErrorMessage = "O título da categoria é obrigatório", AllowEmptyStrings = false)]
        [MinLength(3, ErrorMessage = "O título da categoria deve ter entre 3 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O título da categoria deve ter entre 3 e 100 caracteres")]
        public string Title { get; set; }
    }
}
