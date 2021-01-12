using System.Collections.Generic;
using Data.SchoolSystem.Schools;
using Data.SchoolSystem.Students;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Facade.SchoolSystem.Schools;
using Facade.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pages.SchoolSystem.Students
{
    public abstract class StudentsPage : CommonPage<IStudentsRepository, Student, StudentView, StudentData>
    {


        public IEnumerable<SelectListItem> Schools { get; }


        protected internal readonly ISchoolsRepository schools;

        protected internal StudentsPage(IStudentsRepository StudentsRepository, ISchoolsRepository schoolsRepository) : base(StudentsRepository)
        {
            PageTitle = "Õpilased";
            Schools = CreateSelectList<School, SchoolData>(schoolsRepository);

            schools = schoolsRepository;
        }
        public string GetSchoolName(string studentId)
        {
            foreach (var m in Schools)
            {
                if (m.Value == studentId)
                    return m.Text;
            }

            return "Määramata";
        }
        
        public override string ItemId => Item.Id;

        protected internal override string GetPageUrl() => "/SchoolSystem/Students";

        protected internal override Student ToObject(StudentView view)
        {
            return StudentViewFactory.Create(view);
        }

        protected internal override StudentView ToView(Student obj)
        {
            return StudentViewFactory.Create(obj);
        }
      
    }
}
