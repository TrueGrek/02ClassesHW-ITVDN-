
//Дополнительное задание
//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата
//заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.

using System;
namespace _02ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.date.ToString());


            user.Name = "Vlad";
            Console.WriteLine(user.Name);

            User userGood = new User("fghjk", "Trohi", "Ivanov", 18);
            Console.WriteLine(userGood.date.ToString());
            Console.WriteLine(userGood.Name);
            Console.WriteLine(userGood.Familyname);
            Console.WriteLine(userGood.Login);
            Console.WriteLine(userGood.Age);
            Console.ReadKey();
        }
    }
}
