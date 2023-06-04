using Marathon_OOP2;
using OrderProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Marathon_OOP2
{
    internal class Order
    {
        private const int WholesaleSpecialDiscount = 10;
        private const int OneHundered = 100;

        public Order(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            Date = DateTime.Now;
            Customer = customer;
            Status = OrderStatus.New;

            // Eğer ki yazdığınız sınıfta koleksiyon cinsinden bir property var ise
            // o property constructor aşamasında MUTLAKA INSTANCE'lanmalı
            Items = new List<OrderItem>();
        }

        public DateTime Date { get; }
        public Customer Customer { get; }

        public OrderStatus Status { get; private set; }
        public int SpecialDisctount // Computed property
        {
            get
            {
                return Customer.Type == CustomerType.Wholesale
                    ? WholesaleSpecialDiscount
                    : default;
            }
        }
        public decimal GrossTotal
        {
            get
            {
                // var keyword'ü ile varsayılan (yani 0) değerde bir decimal değişken oluşturmak isterseniz
                // neler yapabilirsiniz? (aslında sadece decimal değil, int harici bir sayısal değişken)
                //var grossTotal = (decimal)0;
                //var grossTotal = default(decimal);
                var grossTotal = 0m; // money

                for (int i = 0; i < Items.Count; i++)
                {
                    grossTotal += Items[i].GrossAmount;
                }

                return grossTotal;
            }
        }
        public decimal NetTotal
        {
            get
            {
                var netTotal = 0m;

                for (var i = 0; i < Items.Count; i++)
                {
                    netTotal += Items[i].NetAmount;
                }

                return netTotal;
            }
        }
        public decimal FinalTotal
        {
            get
            {
                return NetTotal * ((OneHundered - SpecialDisctount) / (decimal)OneHundered);
            }
        }

        // Eğer yazdığımız sınıfta koleksiyon cinsinden bir property var ise
        // o property genellikle (%99 durumda) readonly yapılmalıdır
        // Bazı nadir durumlarda koleksiyon setter metodu açık kalabilir
        public List<OrderItem> Items { get; }

        public void AddItem(Product product, double quantity)
        {
            AddItem(product, quantity, default);
        }

        public void AddItem(Product product, double quantity, int discount)
        {
            var orderItem = new OrderItem(product)
            {
                Quantity = quantity,
                Discount = discount
            };

            AddItem(orderItem);
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void Complete()
        {
            Status = OrderStatus.Completed;
        }

        public void Cancel()
        {
            Status = OrderStatus.Cancelled;
        }


        // Nested Type
        //internal enum OrderStatus
        //{
        //    None = 0,
        //    New
        //}

        // Nested Type / Nested Class
        //internal class OrderItem
        //{
        //    public Product Product { get; set; }
        //}
    }
}