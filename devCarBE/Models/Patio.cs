namespace devCarBE.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Patio
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // Geração automática do ID

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
    }

}
