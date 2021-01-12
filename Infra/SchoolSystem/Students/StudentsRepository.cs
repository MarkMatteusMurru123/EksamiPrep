using Data.SchoolSystem.Students;
using Domain.SchoolSystem.Students;

namespace Infra.SchoolSystem.Students
{
    public sealed class StudentsRepository : UniqueEntityRepository<Student, StudentData>, IStudentsRepository
    {
        public StudentsRepository(ProjectDbContext c) : base(c, c.Students) { }

        protected internal override Student ToDomainObject(StudentData d) => new Student(d);
    }
}
