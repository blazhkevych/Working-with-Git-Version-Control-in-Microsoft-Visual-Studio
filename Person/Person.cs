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

        // Свойство Name.
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        // Свойство Surname.
        public string Surname
        {
            get => _Surname;
            set => _Surname = value;
        }

        // Свойство Age.
        public int Age
        {
            get => _Age;
            set => _Age = value;
        }

        // Свойство Surname.
        public string Phone
        {
            get => _Phone;
            set => _Phone = value;
        }

        // Вывод информации на экран.
        public void Print()
        {
            Console.Write("{0,20}{1,20}{2,9}{3,17}", _Name, _Surname, _Age, _Phone);
        }
    }
}