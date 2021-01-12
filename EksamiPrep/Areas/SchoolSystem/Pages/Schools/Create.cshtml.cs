using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc;
using Pages.SchoolSystem.Schools;

namespace WebApp.Areas.SchoolSystem.Pages.Schools
{
    public class CreateModel : SchoolsPage
    {
        public CreateModel(ISchoolsRepository SchoolsRepository, IStudentsRepository studentsRepository) : base(SchoolsRepository, studentsRepository)
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
