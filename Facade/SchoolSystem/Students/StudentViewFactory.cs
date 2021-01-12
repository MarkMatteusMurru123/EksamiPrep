using Aids;
using Data.SchoolSystem.Students;
using Domain.SchoolSystem.Students;

namespace Facade.SchoolSystem.Students
{
    public static class StudentViewFactory
    {
        public static Student Create(StudentView v)
        {
            var d = new StudentData();
            Copy.Members(v, d);

            return new Student(d);
        }

        public static StudentView Create(Student o)
        {
            var v = new StudentView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
