using Abstraction;

//object initializer sentaksı

Rectangle rectangle = new Rectangle()
{
    SideA = 10,
    SideB = 20,
};

Console.WriteLine($"Dikdörtgenin çevresi:{rectangle.CalculatePerimeter()}");
Console.WriteLine($"Dikdörtgenin alanı:{rectangle.CalculateArea()}");

Circle circle = new Circle()
{
    Radius = 10,
};
Console.WriteLine($"Çemberin çevresi:{circle.CalculatePerimeter()}");
Console.WriteLine($"Çemberin alanı:{circle.CalculateArea()}");

//ikisinde parametresiz çevreyi hesap et ve alan hesap et diyen ortak metod  söz konusu
//yani özünde ortaklaştırabileceğim bir şey

List<Shape> shapes = new List<Shape>();

Rectangle rectangle1 = new Rectangle() { SideA = 5, SideB = 7 };
Rectangle rectangle2 = new Rectangle() { SideA = 10, SideB = 9 };
Rectangle rectangle3 = new Rectangle() { SideA = 12, SideB = 22 };
Rectangle rectangle4 = new Rectangle() { SideA = 15, SideB = 33 };

Circle circle1 = new Circle() { Radius = 6 };
Circle circle2 = new Circle() { Radius = 9 };
Circle circle3 = new Circle() { Radius = 14 };

//eğer tüm şekilleriaynı listede biriktirmek istersek aşağıdaki gibi 
//object listesi oluşturabilirim 

List<object> objecktList = new List<object>();
objecktList.Add(rectangle1);
objecktList.Add(circle3);

// ancak bu durumda koleksiyon elemanlarını bir döngü içerisinde adım adım okurken sıkıntı yaşıyorum.
//her adımda index'inci elemanın hangi tipte olduğunu kontrol etmem gerekiyor 
for (int i = 0; i < objecktList.Count; i++)
{
    if (objecktList[i] is Rectangle)
    {
        Rectangle rec = (Rectangle)objecktList[i];
        Console.WriteLine(rec.CalculatePerimeter());
    }
    else if (objecktList[i] is Circle)
    {
        Circle cir = (Circle)objecktList[i];
        Console.WriteLine(cir.CalculatePerimeter());
    }
}

// yukarıdaki çözümde object kullanımın zorlukları görünüyor 
//bur örneği daha ideal şekilde aşağıdaki gibi bir List<Shape> ile çözmemiz doğru olur

List<Shape> shapeList = new List<Shape>(); 
shapeList.Add(rectangle2);
shapeList.Add(circle1);
shapeList.Add(circle2);
shapeList.Add(circle3);
shapeList.Add(circle1);

for (int i = 0;i < shapeList.Count; i++)
{
    //polmorphisim :
    //aynı kökten gelen nesnelerde aynı davranışın farklı biçimde gerçekleşmesi
    Console.WriteLine(shapeList[i].CalculatePerimeter());
}