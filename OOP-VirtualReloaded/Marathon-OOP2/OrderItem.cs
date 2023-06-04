using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon_OOP2
{
    internal class OrderItem
    {
        private const int Zero = 0;
        private const int OneHundered = 100;

        public OrderItem(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Product = product;
        }

        // Has-a relation
        public Product Product { get; }

        private double _quantity;

        public double Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value >= Zero ? value : default;
            }
        }


        private int _discount;
        public int Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value >= Zero && value <= OneHundered
                    ? value
                    : default;
            }
        }

        public decimal ItemNetPrice
        {
            get
            {
                return Product.Price * ((decimal)(OneHundered - Discount) / 100);
            }
        }

        // Computed property
        public decimal GrossAmount
        {
            get
            {
                return (decimal)Quantity * Product.Price;
            }
        }
        public decimal NetAmount
        {
            get
            {
                return ItemNetPrice * (decimal)Quantity;
            }
        }

        public override string ToString()
        {
            return $"{Product.Name}, {ItemNetPrice.ToString("N")} x {Quantity.ToString("N")} = {NetAmount.ToString("N")}";
        }
    }


}
