Console.Write("Привет, как тебя зовут?: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!!! ");
}
else
{
    Console.Write("Добро пожаловать, ");
    Console.Write(username);
}