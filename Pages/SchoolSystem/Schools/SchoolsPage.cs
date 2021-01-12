using System.Collections.Generic;
using Aids;
using Data.SchoolSystem.Schools;
using Data.SchoolSystem.Students;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Facade.SchoolSystem.Schools;
using Facade.SchoolSystem.Students;

namespace Pages.SchoolSystem.Schools
{
    public abstract class SchoolsPage : CommonPage<ISchoolsRepository, School, SchoolView, SchoolData>
    {
        public IList<StudentView> Students { get; }
        //public IEnumerable<SelectListItem> TimetableEntries { get; }

        protected internal readonly IStudentsRepository students;

        protected internal SchoolsPage(ISchoolsRepository SchoolsRepository, IStudentsRepository studentsRepository) :
            base(SchoolsRepository)
        {
            PageTitle = "Koolid";
            Students = new List<StudentView>();
            students = studentsRepository;
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string GetPageUrl() => "/SchoolSystem/Schools";

        protected internal override School ToObject(SchoolView view)
        {
            return SchoolViewFactory.Create(view);
        }

        protected internal override SchoolView ToView(School obj)
        {
            return SchoolViewFactory.Create(obj);
        }

        public string GetStudentName(string schoolId)
        {
            foreach (var m in Students)
            {
                if (m.SchoolId == schoolId)
                    return m.Name;
            }

            return "Määramata";
        }

        public void LoadDetails(SchoolView item)
        {
            Students.Clear();

            if (item is null) return;
            students.FixedFilter = GetMember.Name<StudentData>(x => x.SchoolId);
            students.FixedValue = item.Id;
            var list = students.Get().GetAwaiter().GetResult();

            foreach (var e in list)
            {
                Students.Add(StudentViewFactory.Create(e));
            }
        }
    }
}
