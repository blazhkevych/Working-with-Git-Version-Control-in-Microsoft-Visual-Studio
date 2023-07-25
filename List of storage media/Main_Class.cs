using Academy_GroupNamespace;

namespace task
{
    // Реализует пользовательский интерфейс приложения, и 
    // демонстрируюет работу с классом Academy_Group.
    internal class Main_Class
    {
        // Главное меню.
        public void MainMenu(ref Academy_Group ag)
        {
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine(@"1. Добавление студентов в группу.
2. Удаление студента из группы.
3. Редактирование данных студента.
4. Печать академической группы.
5. Поиск студента по заданному критерию.
6. Выход из программы.");
                Console.WriteLine();
                Console.WriteLine("Я выбираю: ");

                try
                {
                    choice = Convert.ToString(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите количество студентов для добавления:");
                        int amountOfStudentsToAdd = -1;
                        do
                        {
                            try
                            {
                                amountOfStudentsToAdd = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                Console.WriteLine();
                                Console.WriteLine("Попробуйте еще раз !");
                            }
                        } while (amountOfStudentsToAdd < 0);
                        ag.AddStudent(amountOfStudentsToAdd);
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу.");
                        Console.ReadLine();
                        break;
                    case "2":
                        ag.PrintGroup();
                        Console.WriteLine();
                        Console.WriteLine("Введите № студента для удаления:");
                        int studentNumberToRemove = -1;
                        try
                        {
                            studentNumberToRemove = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        ag.Remove(studentNumberToRemove);
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу.");
                        Console.ReadLine();
                        break;
                    case "3":
                        ag.Edit();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу.");
                        Console.ReadLine();
                        break;
                    case "4":
                        ag.PrintGroup();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу.");
                        Console.ReadLine();
                        break;
                    case "5":
                        ag.Search();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу.");
                        Console.ReadLine();
                        break;
                    case "6":
                        ag.Save();
                        Environment.Exit(0);
                        break;
                }
                MainMenu(ref ag);
            } while (choice != "1" | choice != "2" | choice != "3" | choice != "4" | choice != "5" | choice != "6" | choice != "7");
        }
    }
}