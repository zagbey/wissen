Console.WriteLine(@"//////////////\\\\\\\\\\\\\\
|| Lorem Ipsum CRM System ||
\\\\\\\\\\\\\\//////////////
Lütfen kullanıcı adınızı ve parolanızı giriniz.");

Console.Write("Kullanıcı Adı: ");
Console.ReadLine();

Console.Write("Parola: ");

string password = string.Empty;

while (true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    //ConsoleKeyInfo keyInfo = Console.ReadKey();
    //Thread.Sleep(100);
    //Console.Write('\b');

    if (keyInfo.Key == ConsoleKey.Enter)
    {
        break;
    }

    Console.Write("*");

    password += keyInfo.KeyChar;
}

Console.Write("\n----------------------\n");
Console.Write($"PAROLA TEST: {password}");