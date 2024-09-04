using BusinessLogic;
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
                        ShowDistribution(logic);
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

            logic.AddStudent(name, speciality, group);
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

            logic.RemoveStudent(name);
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

            logic.UpdateStudent(name, speciality, group);
            Console.WriteLine("Данные студента обновлены.");
        }
        /// <summary>
        /// Функция для получения списка студентов через КОНСОЛЬ(QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void ListStudents(Logic logic)
        {
            Console.WriteLine("Список студентов:");
            foreach (var student in logic.GetAllStudents())
            {
                Console.WriteLine($"Имя: {student.Name}, Специальность: {student.Speciality}, Группа: {student.Group}");
            }
        }
        /// <summary>
        /// Функция для вывода гистраграммы через КОНСОЛЬ(не QoL функция)
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        static void ShowDistribution(Logic logic)
        {
            Console.WriteLine("Распределение студентов по специальностям:");
            foreach (var entry in logic.GetSpecialityDistribution())
            {
                Console.WriteLine($"Специальность: {entry.Key}, Количество студентов: {entry.Value}");
            }
        }

    }
}
