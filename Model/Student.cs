namespace Model
{
    public class Student
    {
        // Свойства студента
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        // Конструктор для инициализации объекта Student
        public Student(string name, string speciality, string group)
        {
            Name = name;
            Speciality = speciality;
            Group = group;
        }
    }
}
