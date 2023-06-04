//geneceric tip yazım şekli 


using System.Reflection.Metadata;

List<int> numberlist = new List<int>();
numberlist.Add(4);
numberlist.Add(3);
numberlist.Add(2);

for(int i = 0; i < numberlist.Count; i++) //dizilerde Length burada Count 
{
    Console.WriteLine(numberlist[i]);
}

numberlist[numberlist.Count - 1] = 1;//son elemanını değişmek için kullandık 

numberlist.Remove(20); // değeri 20 olan sayılardan ilk gördüğünü sil

numberlist.RemoveAt(0);// '0' ıncıindexdeki elemanı silmemize yarıyor 

numberlist.RemoveAt(numberlist.Count -1);//sonunca indexteki  elemanı silmemize yarıyor 

// Initializer sentaksı ile List<T> instance'ı oluşturmak
// new List<string>() ifadesindeki List<string>() List tipinin constructor metodu
List<string> strings = new List<string>()
{
    "zeynel",
    "abidin",
    "gencer",
    "122",
};

Console.WriteLine(strings.Count);//ekrana 4 yazdıracak 
strings.Add("wkashimazu");
strings.Remove("gencer");
strings.RemoveAt(0);

//w ile başlayanları silmek 

for (int i = strings.Count - 1; i >= 0; i--)
{
    if (strings[i].StartsWith("W",StringComparison.CurrentCultureIgnoreCase)) // küçük w yazsarsa bile algılasın 
    {
        strings.RemoveAt(i);
    }
}
strings.Insert(0, "wwwww");
//strings.Clear();//bütün elemanları siliyor 

//strings.RemoveRange(3,7);// aralıkdaki değerleri siliyor  // bunun çalışma mantığını incele ! ! ! ! 






Console.ReadKey();