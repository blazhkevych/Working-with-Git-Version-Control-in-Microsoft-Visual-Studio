﻿/*
 * Список студентов академической группы
   Разработать приложение, обладающее следующим набором классов:
   1) класс PersonNamespace включает в себя следующие члены:
   - защищённые поля name (имя), surname (фамилия), age (возраст), 
   phone (телефон);
   - свойства Name, Surname, Age, Phone;
   - конструктор по умолчанию и конструктор с параметрами;
   - метод PrintGroup для вывода информации на экран.
   2) класс StudentNamespace, производный от класса PersonNamespace, включает в себя следующие 
   члены:
   - защищённые поля average (средний балл), number_of_group (номер 
   группы);
   - свойства Average, Number_Of_Group;
   - конструктор по умолчанию и конструктор с параметрами;
   - метод PrintGroup для вывода информации на экран;
   3) класс Academy_Group включает в себя следующие члены:
   - ссылочную переменную, указывающую на массив студентов;
   - счётчик count количества студентов в группе;
   - конструктор по умолчанию;
   - метод Add для добавления студентов в группу;
   - метод Remove для удаления студента из группы (критерий удаления –
   фамилия);
   - метод Edit для редактирования сведений о студенте (критерий –
   фамилия студента);
   - метод печати группы PrintGroup;
   - метод Save для сохранения данных в файл;
   - метод Load для загрузки данных из файла;
   - метод Search для поиска студента по заданному критерию.
   4) класс Main_Class, реализующий пользовательский интерфейс приложения, и 
   демонстрирующий работу с классом Academy_Group.
 */

// Внесение изменения в проект разработчиком blazhkevych.v для фиксации в локальном репозитории.

namespace task
{
    using Academy_GroupNamespace;
    internal class Program
    {
        static void Main(string[] args)
        {
            Academy_Group ag = new Academy_Group();
            ag.Load();
            Main_Class main_Class = new Main_Class();
            main_Class.MainMenu(ref ag);
        }
    }
}