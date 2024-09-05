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
        public void AddStudent(int id,string name, string speciality, string group)
        {
            if (name == string.Empty|| speciality == string.Empty || group == string.Empty) { throw new NotImplementedException(); }
            else
            {
                Student newStudent = new Student(id,name, speciality, group);
                students.Add(newStudent);
            }
        }
        /// <summary>
        /// Удаление студента
        /// </summary>
        /// <param name="name">Имя</param>
        public void RemoveStudent(int number)
        {
            if (students[number]==null)
            {
                throw new NotImplementedException();
            }
            else {
                var studentToRemove = students[number];
                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Обновление параметров студента.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="newSpeciality">Новая Специальность</param>
        /// <param name="newGroup">Новая Группа</param>
        public void UpdateStudent(int id, string newname, string newSpeciality, string newGroup)
        {
            if (id==null) { throw new NotImplementedException(); }
            else
            {
                var studentToUpdate = students[id];
                if (studentToUpdate != null)
                {
                    if (newname != string.Empty)
                    {
                        studentToUpdate.Name = newname;
                    }
                    if(newSpeciality != string.Empty)
                    {
                        studentToUpdate.Speciality = newSpeciality;
                    }
                    if(newGroup != string.Empty)
                    {
                        studentToUpdate.Group = newGroup;
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Метод возвращающий список всех студентов
        /// </summary>
        /// <returns>Список студентов</returns>
        public List<List<string>> GetAllStudents()
        {
            List<List<string>> finallist = new List<List<string>>();
            foreach (var student in students)
            {
                List<string> studentlist = new List<string>
                {
                    student.Id.ToString(),
                    student.Name,
                    student.Speciality,
                    student.Group
                };
                finallist.Add(studentlist);
            }
            return finallist;
        }
        /// <summary>
        /// Метод возвращающий словарь на основе специальностей
        /// </summary>
        /// <returns>Словарь string,int</returns>
        public Dictionary<string, int> GetSpecialityDistribution()
        {
            if(students.Count==0)
            {
                throw new NotImplementedException();
            }
            else
            {
                return students.GroupBy(s => s.Speciality)
                           .ToDictionary(g => g.Key, g => g.Count());
            }
        }
    }
}
