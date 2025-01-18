using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public string? Name { get; set; }

        public string? Descript { get; set; }
        public string? Type { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public string? Producer { get; set; }
        public int RegistrationNumber { get; set; }

        public List<Movement>? Movements { get; set; }
    }
}
