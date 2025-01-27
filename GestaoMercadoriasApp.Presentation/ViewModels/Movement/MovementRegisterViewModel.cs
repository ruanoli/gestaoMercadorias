using GestaoMercadoriasApp.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace GestaoMercadoriasApp.Presentation.ViewModels.Movement
{
    public class MovementRegisterModel
    {
        public int Quantity { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public MovementType Type { get; set; }
        public Guid ProductId { get; set; }
    }
}
