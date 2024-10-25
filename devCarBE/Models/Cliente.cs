using System.ComponentModel.DataAnnotations;

namespace devCarBE.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // Geração automática do ID

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve ter 11 dígitos.")]
        public string CPF { get; set; } // CPF como número, 11 dígitos  

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve ter entre 10 a 11 dígitos.")]
        public string Telefone { get; set; } // Telefone como número

        [EmailAddress(ErrorMessage = "O e-mail está em um formato inválido.")]
        public string Email { get; set; }
    }

}
