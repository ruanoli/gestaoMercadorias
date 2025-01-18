using GestaoMercadoriasApp.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Domain.Models
{
    public class Movement
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public MovementType Type { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public Guid ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
