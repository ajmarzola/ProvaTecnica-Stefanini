using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaTecnica.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
    }

    public class OrderItem
    {
        [Key]
        [ForeignKey("Order")]
        public string OrderId { get; set; }

        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
