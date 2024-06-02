using System;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Domain
{
	public class CartItem
	{
        [Key]
        public int ItemId { get; set; }

        public int CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }
        

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}

