Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Ура, Это же Маша!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}