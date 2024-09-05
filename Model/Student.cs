namespace Model
{
    public class Student
    {
        // Свойства студента
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        // Конструктор для инициализации объекта Student
        public Student(int id,string name, string speciality, string group)
        {
            Id = id;
            Name = name;
            Speciality = speciality;
            Group = group;
        }
    }
}
