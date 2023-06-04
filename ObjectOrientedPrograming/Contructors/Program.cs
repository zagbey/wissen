using Contructors;

Product product = new Product();
product.Name = "Test";
product.UnitPrice = 50152;

Product product2 = new Product();
product2.Name = "limon";

Product product3 = new Product("Patates    "); // patatesi consturctordaki name ile alıyoruz , unitprice ise constructor chainin ile defoul olarak 100 ₺ayarlandığı için 100 oluyor 
                                               // program.csde 28 ve 32. satır kodları 

Console.WriteLine($"Ürün Adı:{product3.Name}, Fiyatı:{product3.UnitPrice}");

