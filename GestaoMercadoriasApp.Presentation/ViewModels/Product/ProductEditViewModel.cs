using GestaoMercadoriasApp.Domain.Models;

namespace GestaoMercadoriasApp.Presentation.ViewModels.Product
{
    public class ProductEditViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Producer { get; set; }
        public int RegistrationNumber { get; set; }
    }
}
