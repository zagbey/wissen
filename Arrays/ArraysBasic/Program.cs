string[] players = new string[3];
// dizileri kullanabilmek için öncelikle o dizinin instance'ını oluşturmak gerekir 
// ınstance : örnek,örnekleme ,nesne örneği 

players[0] = "Tsubasa";
players[1] = "Misaki";
players[2] = "Ishızaki";

//daha önceden atanmış indexdeki alana sonradan yeni bir değer atanabilir
//artık sıfırncı indexte hyuga yazar 
players[0] = "azure";
players[0] = "azure";

int[] numbers = new int[5];

//normalde ilk değeri atanmış değişkenleri herhangi bir işlemde kullanamam ancak dizilerin elemanları varsayılan değerleri ile doldurulduğu için bu bir derlemel hatasına
//sebep olmaz 
int total = numbers[0] + numbers[1] + numbers[2];

/*Tiplerin Varsayılan değerli 
 * string = null 
 * int,long,double vs.(sayısal tiplerin)=0
 * bool = false 
 * */

// dizi elemanının değerini okumak 

numbers[0] = 10;

int firsT = numbers[0];

int lengt = numbers.Length;

// her zaman son elemana bu şekilde ulaşabiliriz  
int lastItem = numbers[numbers.Length-1];

// dizileri yeniden boyutlandırma

Array.Resize(ref players, 15); 

Array.Resize(ref players, players.Length+1);//mevcut boyunu +1 fazlası 