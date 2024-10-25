using System.IO;

namespace devCarBE.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using System;
    using System.ComponentModel.DataAnnotations;

    public class Veiculo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // Geração automática do ID

        [Required(ErrorMessage = "O modelo é obrigatório.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatório.")]
        public double ValorDaDiaria { get; set; } = 500.0; // Valor pré-definido para a diária

        [Required]
        public Guid PatioId { get; set; } // Chave estrangeira do Pátio
    }


}
