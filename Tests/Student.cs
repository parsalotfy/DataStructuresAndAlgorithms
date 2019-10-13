namespace Tests
{

    public class Student
    {

        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}