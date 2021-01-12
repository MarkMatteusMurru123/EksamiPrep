using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Pages.SchoolSystem.Schools;

namespace WebApp.Areas.SchoolSystem.Pages.Schools
{
    public class IndexModel : SchoolsPage
    {
        public IndexModel(ISchoolsRepository SchoolsRepository, IStudentsRepository studentsRepository) : base(SchoolsRepository, studentsRepository)
        {
        }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}