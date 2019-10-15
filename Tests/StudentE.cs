using System;

namespace Tests
{

    public class StudentE : IEquatable<StudentE>
    {

        public StudentE(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public int ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(StudentE other)
        {
            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }

}