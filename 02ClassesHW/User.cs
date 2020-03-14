using System;
using System.Collections.Generic;
using System.Text;

namespace _02ClassesHW
{
    class User
    {
        private string name, familyname, login;
        private int age;
        public readonly DateTime date;

        public string Name{
            get
            {
                if(name == null)
                {
                    return "Field not to fill";
                }
                return name;
            }
            set { name = value; }
        }
        public string Familyname
        {
            get
            {
                if (familyname == null)
                {
                    return "Field not to fill";
                }
                return familyname;
            }
            set { familyname = value; }
        }
        public string Login
        {
            get
            {
                if (login == null)
                {
                    return "Field not to fill";
                }
                return login;
            }
            set { login = value; }
        }

        public int Age
        {
            get
            {
                if (age <= 0)
                {
                    return 18;
                }
                return age;
            }
            set { age = value; }
        }
        //Конструктор по умолчанию
        public User()
        {
            date = DateTime.Now;
        }

        public User(string name, string familyname, string login, int age)
        {
            this.name = name;
            this.familyname = familyname;
            this.login = login;
            this.age = age;
            date = DateTime.Now;
        }
    }
}
