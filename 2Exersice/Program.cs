﻿//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.

using System;

namespace _2Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter con = new Converter(0.35, 25.86, 26.0963);
            con.ToUsd(5.5);
            con.inUsd(10.0);
            con.ToRub(100.0);
            Console.ReadKey();
        }
    }
}
