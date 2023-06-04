using Example02;

Laptop laptop = new Laptop();

Mause mause = new Mause();

Product product1 = new Product();

product1.Name = "Domates";
product1.UnitPrice = 30;

Product product2 = new Product();
product2.Name = "bilgisayar";
product2.UnitPrice = 15000;

ProductStock stock1 = new ProductStock();
stock1.Unit = "kilogram";
stock1.StockAmount = 1500;
stock1.Product = product1;


Product[] products = new Product[3];

products[0] = product1;
products[1] = product2;
products[2] = new Product();
products[2].Name = "PATATES";

ProductStock[] stocks = new ProductStock[2];
stocks[0] = stock1;
stocks[1] = new ProductStock();
stocks[1].Product = product2;
stocks[1].StockAmount = 100;
stocks[1].Unit = "Adet";


for (int i = 0; i < stocks.Length; i++)
{
    decimal total = stocks[i].Product.UnitPrice * stocks[i].StockAmount;
    Console.WriteLine($"{stocks[i].Product.Name} ürünü tahmini geliri : {total}");
    break;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

mause.Dpi = 16000;
mause.ButtonCount = 5;
mause.Name = "Logitech X3";
mause.Stock = 20;
mause.Description = "Oyuncu mouse";
mause.UnitPrice = 1500;
mause.IsActive = false;

Console.WriteLine($"{mause.Name} {mause.Description} {mause.HasStockString}");



//laptop.Description = "monster Tulpar v20.3";
//laptop.Name = "monster";
//laptop.CpuType = "intel"; // central processing unit
//laptop.Ram = 32;
////laptop.ScreenResolution = "2560x1080";