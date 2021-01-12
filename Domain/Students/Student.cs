using Data.Students;
using Domain.Abstractions;

namespace Domain.Students
{
    public sealed class Student : Entity<StudentData>
    {
        public Student() : this(null) { }

        public Student(StudentData data) : base(data) { }
    }
}
