﻿Console.Write("Введите своё имя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, Это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}  
