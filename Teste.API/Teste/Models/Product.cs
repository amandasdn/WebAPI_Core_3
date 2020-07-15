using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título do Produto")]
        [Required(ErrorMessage = "O título do produto é obrigatório", AllowEmptyStrings = false)]
        [MinLength(3, ErrorMessage = "O título do produto deve ter entre 3 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O título do produto deve ter entre 3 e 100 caracteres")]
        public string Title { get; set; }

        [Display(Name = "Descrição do Produto")]
        [MaxLength(1500, ErrorMessage = "A descrição do produto deve ter entre 3 e 100 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "O preço do produto é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Preço inválido")]
        public decimal Price { get; set; }

        [Display(Name = "ID da Categoria")]
        [Required(ErrorMessage = "O id da categoria é obrigatória")]
        [Range(1, int.MaxValue, ErrorMessage = "ID da categoria é inválido")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
