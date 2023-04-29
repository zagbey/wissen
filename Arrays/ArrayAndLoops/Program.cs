string[] names = new string[3];
names[0] = "tusubasa";
names[1] = "tusubasa1";
names[2] = "tusubasa2";

int index = 0;
// ekrana 5 adet yazdırma 
while (index < names.Length)
{
    Console.WriteLine(names[index]);
    index++;
}

// ekrandan 5 adet okuma 

string[] inputs = new string[5];
int counter = 0;

while (counter < inputs.Length)
{
    inputs[counter] = Console.ReadLine();
    counter++;
}
Console.WriteLine("*****************************************************");
int counterr = inputs.Length - 1;
while (counterr >= 0)
{
    Console.WriteLine(inputs[counterr]);
    counterr--;
}