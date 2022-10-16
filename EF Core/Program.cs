using System;
using EF_Core;


while (true)
{
    UserService userService = new UserService();

    Console.WriteLine("Введите имя");
    string name = Console.ReadLine();

    Console.WriteLine("Введите возраст");
    int age = int.Parse(Console.ReadLine());

    var user = userService.AddUser(name: name, age: age);



}
