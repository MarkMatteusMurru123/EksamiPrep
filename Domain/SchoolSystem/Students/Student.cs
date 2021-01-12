using Data.SchoolSystem.Students;
using Domain.Abstractions;

namespace Domain.SchoolSystem.Students
{
    public sealed class Student : Entity<StudentData>
    {
        public Student() : this(null) { }

        public Student(StudentData data) : base(data) { }
    }
}
