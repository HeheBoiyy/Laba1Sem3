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
                Console.WriteLine("\nВведите команду: 1.Add, 2.Remove, 3.Update, 4.List, 5.Distribution, 6.Exit programm");
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
                    case "6":
                        Environment.Exit(0);
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

            int numberofstudent = logic.GetAllStudents().Count();

            try {logic.AddStudent(numberofstudent,name, speciality, group); }
            catch
            {
                Console.WriteLine("Ошибка!");
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
            if (logic.GetAllStudents().Count==0)
            {
                Console.WriteLine("Список студентов пуст!");
                return;
            }
            else
            {
                Console.Write("Введите номер студента для удаления: \n");
                int i = 0;
                foreach (var student in logic.GetAllStudents())
                {
                    Console.WriteLine($"Номер {i}, Имя:{student[1]} Специальность:{student[2]} Группа:{student[3]}");
                    i++;
                }
                int chosennumber = Convert.ToInt32(Console.ReadLine());

                try { logic.RemoveStudent(chosennumber); }
                catch
                {
                    Console.WriteLine("Ошибка!");
                    return;
                }
                Console.WriteLine("Студент удален.");
            }
        }
        /// <summary>
        /// Функция для обновления студента через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void UpdateStudent(Logic logic)
        {
            Console.WriteLine("Выберите номер студента для изменения:");
            if (logic.GetAllStudents().Count == 0)
            {
                Console.WriteLine("Сипсок студентов пуст!");
                return;
            }
            else
            {
                int i = 0;
                foreach (var student in logic.GetAllStudents())
                {
                    Console.WriteLine($"Номер {i}, Имя:{student[1]} Специальность:{student[2]} Группа:{student[3]}");
                    i++;
                }
                int chosennumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите новое имя студента: ");
                string name = Console.ReadLine();

                Console.Write("Введите новую специальность: ");
                string speciality = Console.ReadLine();

                Console.Write("Введите новую группу: ");

                string group = Console.ReadLine();

                try { logic.UpdateStudent(chosennumber, name, speciality, group); }
                catch
                {
                    Console.WriteLine("Ошибка! Одно из полей пустое");
                    return;
                }
                Console.WriteLine("Данные студента обновлены.");
            }
            
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
                    Console.WriteLine($"Имя: {student[0]}, Специальность: {student[1]}, Группа: {student[2]}");
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
