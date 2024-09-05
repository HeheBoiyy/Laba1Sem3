using BusinessLogic;
using System.Drawing;
using Spectre.Console;
using System.Collections.Generic;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            string command;

            do
            {
                Console.WriteLine("\nВведите команду: 1.Add, 2.Remove, 3.Update, 4.List, 5.Distribution, 6.Exit");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "1":
                        AddStudent(logic);
                        break;
                    case "2":
                        RemoveStudent(logic);
                        break;
                    case "3":
                        UpdateStudent(logic);
                        break;
                    case "4":
                        ListStudents(logic);
                        break;
                    case "5":
                        try { var testdata = logic.GetSpecialityDistribution(); }
                        catch
                        {
                            Console.WriteLine("Ошибка!");
                            break;
                        }
                        var data = logic.GetSpecialityDistribution();
                        ShowDistribution(data);
                        break;
                }
            } while (command != "exit");
        }
        // все функции изложенные ниже НЕ являются логикой и просто делают код красивее.
        /// <summary>
        /// Функция для добавления студента через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void AddStudent(Logic logic)
        {
            Console.Write("Введите имя студента: ");
            string name = Console.ReadLine();

            Console.Write("Введите специальность студента: ");
            string speciality = Console.ReadLine();

            Console.Write("Введите группу студента: ");
            string group = Console.ReadLine();
            try {logic.AddStudent(name, speciality, group); }
            catch
            {
                Console.WriteLine("Ошибка! Одно из полей пустое");
                return;
            }
            Console.WriteLine("Студент добавлен.");
        }
        /// <summary>
        /// Функция для удаления студента через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void RemoveStudent(Logic logic)
        {
            Console.Write("Введите имя студента для удаления: ");
            string name = Console.ReadLine();

            try { logic.RemoveStudent(name); }
            catch
            {
                Console.WriteLine("Ошибка!");
                return;
            }
            Console.WriteLine("Студент удален.");
        }
        /// <summary>
        /// Функция для обновления студента через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void UpdateStudent(Logic logic)
        {
            Console.Write("Введите имя студента для изменения: ");
            string name = Console.ReadLine();

            Console.Write("Введите новую специальность: ");
            string speciality = Console.ReadLine();

            Console.Write("Введите новую группу: ");

            string group = Console.ReadLine();

            try { logic.UpdateStudent(name, speciality, group); }
            catch
            {
                Console.WriteLine("Ошибка! Одно из полей пустое");
                return;
            }
            Console.WriteLine("Данные студента обновлены.");
        }
        /// <summary>
        /// Функция для получения списка студентов через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void ListStudents(Logic logic)
        {
            Console.WriteLine("Список студентов:");
            if (logic.GetAllStudents().Count > 0)
            {
                foreach (var student in logic.GetAllStudents())
                {
                    Console.WriteLine($"Имя: {student.Name}, Специальность: {student.Speciality}, Группа: {student.Group}");
                }
            }
            else
            {
                Console.WriteLine("Студентов нет");
            }
        }
        /// <summary>
        /// Функция для вывода гистраграммы через КОНСОЛЬ(не QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void ShowDistribution(Dictionary<string,int> data)
        {
            
            var chart = new BarChart().Width(60).Label("[green bold]Гистограмма[/]");
            foreach (var entry in data)
            {
                chart.AddItem(entry.Key, entry.Value,Spectre.Console.Color.Aqua);
            }

            AnsiConsole.Write(chart);
        }

    }
}
