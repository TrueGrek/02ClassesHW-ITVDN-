using System;
using System.Collections.Generic;
using System.Text;

namespace _3Exersice
{
    class Employ
    {
        private string name, secondName, post;
        private int exp;

        public Employ(string name, string secondName)
        {
            this.name = name;
            this.secondName = secondName;
        }

        public string Name
        {
            get
            {
                if (name == null)
                {
                    return "Field not to fill";
                }
                return name;
            }
            set { name = value; }
        }
        public string SecondName
        {
            get
            {
                if (secondName == null)
                {
                    return "Field not to fill";
                }
                return secondName;
            }
            set { secondName = value; }
        }
        public string Post
        {
            get
            {
                if (post == null)
                {
                    return "Field not to fill";
                }
                return post;
            }
            set { post = value; }
        }

        public int Exp
        {
            get
            {
                if (exp <= 0)
                {
                    return 1;
                }
                return exp;
            }
            set { exp = value; }
        }

        public double CountSalary()
        {
            double salary;
            switch (post.ToLower())
            {
                case "manager": salary = 100;
                    break;
                case "hacker":
                    salary = 110;
                    break;
                case "studyer":
                    salary = 50;
                    break;
                default: salary = 75;
                    break;
            }

            switch (exp)
            {
                case 0:
                    salary *= 1;
                    break;
                case 1:
                    salary *= 2;
                    break;
                case 2:
                    salary *= 4;
                    break;
                default:
                    salary *= 1;
                    break;
            }
            return salary;
        } 

        public void ShowSalary()
        {
            Console.WriteLine("Ваша зарплата: {0} Подоходный налог: {1}", CountSalary(), CountSalary() * 0.17);
        }


    }
}
