using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc;
using Pages.SchoolSystem.Students;

namespace WebApp.Areas.SchoolSystem.Pages.Students
{
    public class CreateModel : StudentsPage
    {
        public CreateModel(IStudentsRepository StudentRepository, ISchoolsRepository schoolsRepository) : base(StudentRepository, schoolsRepository)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();

            return Redirect(IndexUrl);
        }
    }
}