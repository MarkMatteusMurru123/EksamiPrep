using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc;
using Pages.SchoolSystem.Students;

namespace WebApp.Areas.SchoolSystem.Pages.Students
{
    public class DetailsModel : StudentsPage
    {
        public DetailsModel(IStudentsRepository StudentsRepository, ISchoolsRepository schoolsRepository) : base(StudentsRepository, schoolsRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);

            return Page();
        }
    }
}