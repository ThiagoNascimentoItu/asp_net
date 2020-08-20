using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_bo.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigátorio")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimo 5 letras")]
        [Display(Name = "Informe o nome")]
        public string Nome { get; set; }

        public string Sexo { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
