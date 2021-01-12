using System;
using System.Collections.Generic;
using System.Text;
using Aids;
using Data.Schools;
using Domain.Schools;

namespace Facade.Schools
{
    public static class SchoolViewFactory
    {
        public static School Create(SchoolView v)
        {
            var d = new SchoolData();
            Copy.Members(v, d);

            return new Domain.Schools.School(d);
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
