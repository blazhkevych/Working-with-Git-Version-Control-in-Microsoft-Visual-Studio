namespace StudentNamespace
{
    using PersonNamespace;
    using System;
    using System.Xml.Linq;

    public class Student : Person
    {
        protected double _Average;            // Средний балл.
        protected string _NumberOfGroup;      // Номер группы.

        // Конструктор по умолчанию.
        public Student() : this("неизвестно", "неизвестно", 0, "неизвестно", 0.0, "неизвестно") { }

        // Конструктор с параметрами.
        public Student(string name, string surname, int age, string phone, double average, string numberOfGroup)
            : base(name, surname, age, phone)
        {
            _Average = average;
            _NumberOfGroup = numberOfGroup;
        }
    }
}