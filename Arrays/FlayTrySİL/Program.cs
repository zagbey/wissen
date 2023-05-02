string name = "Zeynel Abidin Gencer";

int counter = 0;

bool flag = true;

while (counter < name.Length)
{
    if (name[counter] == ' ')
    {
        Console.Write(" ");
        flag = true;
    }
    else if (flag)
    {
        Console.Write(name[counter]);
        flag = false;
    }
    else
    {
        Console.Write("*");
        
    }
    counter++;

}