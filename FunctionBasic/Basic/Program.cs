

//Fonksiyon yazma kuralları 
//1.fonksiyonun dönüş tipini belirle (eğer ki değer dönmüyorsa void)
//2.fonksiyonun ismini yaz 
//2.1 fonksiyon ismi PascalCase olsun ve yapacağı işe benzer bi isim verirsek okunabilrliği ve fonksiyon olduğunu anlaşılır 
// ismniden sonra ,() parametre parantezleri yazılır eğer bir parametresi yoksa bu parantezler boş yazılır.
void WriteStar(int count)
{
    for(int i = 0; i < count; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}     
WriteStar(10);