using Data.Schools;
using Domain.Schools;

namespace Infra.Students
{
    public sealed class SchoolsRepository : UniqueEntityRepository<School, SchoolData>, ISchoolsRepository
    {
        public SchoolsRepository(ProjectDbContext c) : base(c, c.Schools) { }

        protected internal override School ToDomainObject(SchoolData d) => new School(d);
    }
}
