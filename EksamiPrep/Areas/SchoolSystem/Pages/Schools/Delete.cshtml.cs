using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Microsoft.AspNetCore.Mvc;
using Pages.SchoolSystem.Schools;

namespace WebApp.Areas.SchoolSystem.Pages.Schools
{
    public class DeleteModel : SchoolsPage
    {
        public DeleteModel(ISchoolsRepository SchoolsRepository, IStudentsRepository studentsRepository
            ) : base(SchoolsRepository, studentsRepository )
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