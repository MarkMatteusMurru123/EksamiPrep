﻿using Aids;
using Data.SchoolSystem.Schools;
using Domain.SchoolSystem.Schools;

namespace Facade.SchoolSystem.Schools
{
    public static class SchoolViewFactory
    {
        public static School Create(SchoolView v)
        {
            var d = new SchoolData();
            Copy.Members(v, d);

            return new School(d);
        }

        public static SchoolView Create(School o)
        {
            var v = new SchoolView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
