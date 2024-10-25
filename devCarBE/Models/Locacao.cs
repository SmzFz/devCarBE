namespace devCarBE.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Locacao
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // Geração automática do ID

        [Required(ErrorMessage = "O DiasLocados é obrigatório.")]
        public int DiasLocados { get; set; }

        public double ValorLocacao {  get; set; }


        [Required]
        public Guid ClienteId { get; set; } // Alterado para Guid

        [Required]
        public Guid VeiculoId { get; set; } // Alterado para Guid


    }

}
