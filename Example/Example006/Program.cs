Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "валера")
{
    Console.WriteLine("OMG, Hi Valera");
} 
else
{
    Console.WriteLine("hi, friend");
    Console.WriteLine(username);
}