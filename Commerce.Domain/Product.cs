﻿using System;
namespace Commerce.Domain
{
	public class Product
	{
        
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
        public string Photo { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

