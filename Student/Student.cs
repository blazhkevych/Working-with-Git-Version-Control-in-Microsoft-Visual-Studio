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

        // Свойство _Average.
        public double Average
        {
            get => _Average;
            set => _Average = value;
        }

        // Свойство NumberOfGroup.
        public string NumberOfGroup
        {
            get => _NumberOfGroup;
            set => _NumberOfGroup = value;
        }

        // Вывод информации на экран.
        public new void Print()
        {
            base.Print();
            Console.Write("{0,14}{1,14}", _Average, _NumberOfGroup);
        }

        // Деконструкторы позволяют выполнить декомпозицию объекта на отдельные части.
        public void Deconstruct(out string name, out string surname, out int age, out string phone, out double average, out string numberOfGroup)
        {
            name = _Name;
            surname = _Surname;
            age = _Age;
            phone = _Phone;
            average = _Average;
            numberOfGroup = _NumberOfGroup;
        }
    }
}

// Изменение в проекте разработчиком blazhkevych.v_2 для фиксации в локальном репозитории, в ветви Test.