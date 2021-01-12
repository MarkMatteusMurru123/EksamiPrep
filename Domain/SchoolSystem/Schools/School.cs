using Data.SchoolSystem.Schools;
using Domain.Abstractions;

namespace Domain.SchoolSystem.Schools
{
    public sealed class School : Entity<SchoolData>
    {
        public School() : this(null) { }

        public School(SchoolData data) : base(data) { }
    }
}
