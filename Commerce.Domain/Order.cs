using System;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Domain
{
	public class Order
	{

        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}

