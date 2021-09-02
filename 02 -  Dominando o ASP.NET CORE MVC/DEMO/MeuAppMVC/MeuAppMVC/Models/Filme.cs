using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuAppMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de lançamento é obrigatório")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set;}

        [Range(1, 100, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o valor")]
        [Column(TypeName = "decimal(18,2")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Somente números")]
        [Required(ErrorMessage = "Preencha o campo avaliação")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
