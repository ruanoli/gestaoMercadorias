using GestaoMercadoriasApp.Domain.Models.Enums;

namespace GestaoMercadoriasApp.Presentation.ViewModels.Movement
{
    public class MovementConsultViewModel
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public MovementType Type { get; set; }
        public Guid ProductId { get; set; }
    }
}
