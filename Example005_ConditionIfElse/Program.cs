Console.Write("Введите имя пользовател:");
string username = Console.ReadLine();

if(username.ToLower() == "сиб")
{
    Console.WriteLine("Ура, это же БЕЛЯШ!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
