using System;
using System.Collections.Generic;
using System.Text;
using Data.Schools;
using Data.Students;
using Domain.Abstractions;

namespace Domain.Schools
{
    public sealed class School : Entity<SchoolData>
    {
        public School() : this(null) { }

        public School(SchoolData data) : base(data) { }
    }
}
