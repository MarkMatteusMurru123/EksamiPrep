using Data.SchoolSystem.Schools;
using Domain.SchoolSystem.Schools;

namespace Infra.SchoolSystem.Schools
{
    public sealed class SchoolsRepository : UniqueEntityRepository<School, SchoolData>, ISchoolsRepository
    {
        public SchoolsRepository(ProjectDbContext c) : base(c, c.Schools) { }

        protected internal override School ToDomainObject(SchoolData d) => new School(d);
    }
}
