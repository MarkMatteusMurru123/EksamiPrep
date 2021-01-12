using Aids;
using Data.Students;
using Domain.Students;

namespace Facade.Students
{
    public static class StudentViewFactory
    {
        public static Student Create(StudentView v)
        {
            var d = new StudentData();
            Copy.Members(v, d);

            return new Domain.Students.Student(d);
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
