namespace PersonNamespace
{
    public class Person
    {
        protected string _Name;     // Имя.
        protected string _Surname;  // Фамилия.
        protected int _Age;          // Возраст.
        protected string _Phone;    // Телефон.

        // Конструктор по умолчанию.
        public Person() : this("неизвестно", "неизвестно", 0, "неизвестно") { }

        // Конструктор с параметрами.
        public Person(string name, string surname, int age, string phone)
        {
            _Name = name;
            _Surname = surname;
            _Age = age;
            _Phone = phone;
        }
    }
}