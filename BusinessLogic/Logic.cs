using Model;
namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> students = new List<Student>(); // PRIVATный список студентов
        /// <summary>
        /// Добавление студента
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="speciality">Специальность</param>
        /// <param name="group">Группа</param>
        public void AddStudent(string name, string speciality, string group)
        {
            Student newStudent = new Student(name, speciality, group);
            students.Add(newStudent);
        }
        /// <summary>
        /// Удаление студента
        /// </summary>
        /// <param name="name">Имя</param>
        public void RemoveStudent(string name)
        {
            var studentToRemove = students.FirstOrDefault(s => s.Name == name);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
            }
        }
        /// <summary>
        /// Обновление параметров студента.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="newSpeciality">Новая Специальность</param>
        /// <param name="newGroup">Новая Группа</param>
        public void UpdateStudent(string name, string newSpeciality, string newGroup)
        {
            var studentToUpdate = students.FirstOrDefault(s => s.Name == name);
            if (studentToUpdate != null)
            {
                studentToUpdate.Speciality = newSpeciality;
                studentToUpdate.Group = newGroup;
            }
        }
        /// <summary>
        /// Метод возвращающий список всех студентов
        /// </summary>
        /// <returns>Список студентов</returns>
        public List<Student> GetAllStudents()
        {
            return students;
        }
        /// <summary>
        /// Метод возвращающий словарь на основе специальностей
        /// </summary>
        /// <returns>Словарь string,int</returns>
        public Dictionary<string, int> GetSpecialityDistribution()
        {
            return students.GroupBy(s => s.Speciality)
                           .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
