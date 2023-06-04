using Marathon_OOP2;


var product01 = new Product("Bilgisayar")
{
    Price = 20000
};

var product02 = new Product("Cep telefonu")
{
    Price = 25000
};

Product product03 = new Product("Kahve makinası")
{
    Price = 5000
};

var orderItem01 = new OrderItem(product01)
{
    Quantity = 2,
    Discount = 10
};

OrderItem orderItem02 = new OrderItem(product02)
{
    Quantity = 5
};

var orderItem03 = new OrderItem(product03)
{
    Quantity = 3,
    Discount = 25
};

Console.WriteLine(orderItem01);
Console.WriteLine(orderItem02);
Console.WriteLine(orderItem03);



var tsubasa = new Customer("Tsubasa");
tsubasa.Type = CustomerType.Retail;

// bir enum değeri int tipine cast edilebilir
int customerTypeValue = (int)tsubasa.Type;

// bir integer, bir enum tipine cast edilebilir
CustomerType customerType = (CustomerType)2;


Console.WriteLine("\n----------------------------------------------\n");

var customer1 = new Customer("Kojiro Hyuga")
{
    Type = CustomerType.Wholesale
};

var order1 = new Order(customer1);
order1.AddItem(product01, 10);

var orderSummary = order1.ToString();

/*
 * 2023.06.04 13:50
 * Tsubasa Ozora
 * 
 * Bilgisayar       10 x 200,000.00
 * Cep telefonu     4  x 120,000.00
 */


//order1.AddItem(product02, 1);

//order1.Items.Add(orderItem01);
//order1.Items.Add(orderItem02);

//order1.AddItem(orderItem01);