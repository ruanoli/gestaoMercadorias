using GestaoMercadoriasApp.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Domain.Models
{
    public class Movement
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public ProductType Type { get; set; }
        public Guid ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
