using System.ComponentModel.DataAnnotations;

namespace PandaPharmacyWeb.Models
{
    public class Order
    {
        public Order()
        {
        }

        public Order(
        int? orderId,
        DateTime? orderDate,
        string? customerNo,
        int? productId,
        int? quantity)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            CustomerNo = customerNo;
            ProductId = productId;
            Quantity = quantity;
        }
        public int? OrderId { get; set; }
        [Required]
        public DateTime? OrderDate { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string? CustomerNo { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? Quantity { get; set; }
    }
}
