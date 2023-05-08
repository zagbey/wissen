/*Bir integer dizisindeki elemanlardan yalnızca 5'e bölünebilenleri yeni bir diziye kopyalayın.
 * İşlem sonunda elemanları - aynı indexteki değerler yan yana gelecek şekilde - alt alta yazdırın*/

Random random = new Random();
int[] ints = new int[40];

int index = 0;
while (index < ints.Length)
{
    ints[index] = random.Next(1,101); //1 ile 100 arası sayı üretip dizinin indexinci elemanına atıyor 
    index++;
}

int[] copyints = new int[0];

for (int i = 0; i < ints.Length; i++)