using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracter")]
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set;}

        [DataType(DataType.DateTime, ErrorMessage ="Data em formato incorreto")]
        [Display(Name ="Data de Lançamento")]
        [Required(ErrorMessage = "O campo Data de lançamento é obrigatório")]
        public DateTime DataLancamento { get; set; }

        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        [Required(ErrorMessage = "Preencha o genero")]
        public string Genero { get; set; }

        [Range(1, 100, ErrorMessage ="Valor de 1 a 100")]     
        [Column(TypeName= "decimal(18,2)")]
        [Required(ErrorMessage = "Preencha o Valor")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "Preencha o campo avaliação")]
        public int Avaliacao { get; set; }

    }
}
