//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
//инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
//сбор.
//Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность),
//оклад и налоговый сбор.

using System;

namespace _3Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ("Vasay", "Ivanov");
            employ.Post = "Hacker";
            employ.Exp = 2;
            Console.WriteLine(employ.Name + " " + employ.SecondName + " " + employ.Post.ToUpper());
            employ.ShowSalary();
            Console.ReadKey();
        }
    }
}
