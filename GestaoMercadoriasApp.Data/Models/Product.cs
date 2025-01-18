using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Descript { get; set; }
        public string? Type { get; set; }
        public string? Producer { get; set; }
        public int RegistrationNumber { get; set; }

        public List<Movement>? Movements { get; set; }
    }
}
