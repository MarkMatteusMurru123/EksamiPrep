using Data.Students;
using Domain.Students;

namespace Infra.Students
{
    public sealed class StudentsRepository : UniqueEntityRepository<Student, StudentData>, IStudentsRepository
    {
        public StudentsRepository(ProjectDbContext c) : base(c, c.Students) { }

        protected internal override Student ToDomainObject(StudentData d) => new Student(d);
    }
}
