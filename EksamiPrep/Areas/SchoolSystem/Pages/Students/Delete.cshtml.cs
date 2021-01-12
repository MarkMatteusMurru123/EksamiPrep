using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc;
using Pages.SchoolSystem.Students;

namespace WebApp.Areas.SchoolSystem.Pages.Students
{
    public class DeleteModel : StudentsPage
    {
        public DeleteModel(IStudentsRepository StudentsRepository, ISchoolsRepository schoolsRepository) : base(StudentsRepository,schoolsRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);

            return Redirect(IndexUrl);
        }
    }
}