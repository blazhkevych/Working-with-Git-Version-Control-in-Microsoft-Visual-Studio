using StudentNamespace;
using System.Collections;
using System.Globalization;
using System.Text;

namespace Academy_GroupNamespace
{
    public class Academy_Group
    {
        private ArrayList _Group = new();

        // Добавление студентов в группу.
        public void AddStudent(int amountOfStudentsToAdd)
        {
            Console.Clear();
            string name = null, surname = null, phone = null, numberOfGroup = null;
            int age = 0, studCounter = 1;
            double average = 0.0;
            while (amountOfStudentsToAdd > 0)
            {
                try
                {
                    Console.WriteLine("\nЗаполните данные о студенте № {0}", studCounter);

                    Console.WriteLine();
                    Console.Write("Имя: ");
                    name = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Фамилия: ");
                    surname = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Телефон: ");
                    phone = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Средний балл: ");
                    average = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Номер группы: ");
                    numberOfGroup = Convert.ToString(Console.ReadLine()) ?? "null";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Student st = new(name, surname, age, phone, average, numberOfGroup);
                _Group.Add(st);

                amountOfStudentsToAdd--;
                studCounter++;
            }
        }

        // Удаление студента из группы (критерий удаления – фамилия).
        public void Remove(int studentNumberToRemove)
        {
            if (_Group.Count == 0)
                Console.WriteLine("В группе нету студентов!");
            else
            {
                _Group.RemoveAt(studentNumberToRemove);
                Console.WriteLine();
                Console.WriteLine("Студенти удален !");
            }
        }


        // Редактирование сведений о студенте (критерий – фамилия студента).
        public void Edit()
        {
            Console.Clear();
            if (_Group.Count == 0)
            {
                Console.WriteLine("В группе нету студентов!");
            }
            else
            {
                PrintGroupHeader();
                for (var index = 0; index < _Group.Count; index++)
                {
                    Console.Write("   " + index); (_Group[index] as Student)?.Print();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Введите № студента для редактирования:");
                int studentNumberToEdit;
                try
                {
                    studentNumberToEdit = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }

                try
                {
                    Console.WriteLine("\nЗаполните новые данные о студенте.");

                    Console.WriteLine();
                    Console.Write("Имя: ");
                    (_Group[studentNumberToEdit] as Student).Name = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Фамилия: ");
                    (_Group[studentNumberToEdit] as Student).Surname = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Возраст: ");
                    (_Group[studentNumberToEdit] as Student).Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Телефон: ");
                    (_Group[studentNumberToEdit] as Student).Phone = Convert.ToString(Console.ReadLine()) ?? "null";

                    Console.WriteLine();
                    Console.Write("Средний балл: ");
                    (_Group[studentNumberToEdit] as Student).Average = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Номер группы: ");
                    (_Group[studentNumberToEdit] as Student).NumberOfGroup = Convert.ToString(Console.ReadLine()) ?? "null";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Печать группы.
        public void PrintGroup()
        {
            Console.Clear();
            if (_Group.Count == 0)
            {
                Console.WriteLine("В группе нету студентов!");
            }
            else
            {
                PrintGroupHeader();
                for (var index = 0; index < _Group.Count; index++)
                {
                    Console.Write("   " + index); (_Group[index] as Student).Print();
                    Console.WriteLine();
                }
            }
        }

        // Печать хедера группы.
        private void PrintGroupHeader()
        {
            Console.Write($"{" № ",5}{"Имя",20}{"Фамилия",20}{"Возраст",9}{"Телефон",17}{"Средний балл",14}{"Номер группы",14}");
            Console.WriteLine();
        }

        // Сохранение данных в файл.
        public void Save()
        {
            StreamWriter sw = null;
            sw = new StreamWriter("Group of students.txt", false);
            foreach (var t in _Group)
            {
                (string name, string surname, int age, string phone, double average, string numberOfGroup) = t as Student;

                try
                {
                    sw.WriteLine(name);
                    sw.WriteLine(surname);
                    sw.WriteLine(age);
                    sw.WriteLine(phone);
                    sw.WriteLine(average);
                    sw.WriteLine(numberOfGroup);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            sw.Close();
        }

        // Загрузка данных из файла.
        public void Load()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Group of students.txt", Encoding.Default);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            string name;
            try
            {
                while ((name = sr.ReadLine()) != null)
                {
                    Student st = new Student(name, sr.ReadLine(), Convert.ToInt32(sr.ReadLine()),
                        sr.ReadLine(), Convert.ToDouble(sr.ReadLine()), sr.ReadLine());
                    _Group.Add(st);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            sr?.Close();
        }

        // Поиск студента по заданному критерию.
        public void Search()
        {
            Console.Clear();
            if (_Group.Count == 0)
                Console.WriteLine("В группе нету студентов!");
            else
            {
                Console.Write("Поиск: ");
                string criterion;
                try
                {
                    criterion = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }

                Console.WriteLine();
                bool firstMatch = false;
                int coincidence = 0; // Количество совпадений при поиске.
                for (var index = 0; index < _Group.Count; index++)
                {
                    if (
                        (_Group[index] as Student)?.Name.ToLower() == criterion?.ToLower() |
                        (_Group[index] as Student)?.Surname.ToLower() == criterion?.ToLower() |
                        (_Group[index] as Student)?.Age.ToString() == criterion?.ToLower() |
                        (_Group[index] as Student)?.Phone.ToLower() == criterion?.ToLower() |
                        (_Group[index] as Student)?.Average.ToString(CultureInfo.CurrentCulture) == criterion |
                        (_Group[index] as Student)?.NumberOfGroup.ToLower() == criterion?.ToLower()
                    )
                    {
                        if (firstMatch == false)
                            PrintGroupHeader();
                        firstMatch = true;
                        coincidence++;
                        Console.Write("   " + index);
                        (_Group[index] as Student)?.Print();
                        Console.WriteLine();
                    }
                }

                if (coincidence == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Совпадений не найдено.");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Поиск завершен.");
                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.ReadLine();

            }
        }
    }
}