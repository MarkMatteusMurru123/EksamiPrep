using System.Threading.Tasks;
using Domain.SchoolSystem.Schools;
using Domain.SchoolSystem.Students;
using Pages.SchoolSystem.Students;

namespace WebApp.Areas.SchoolSystem.Pages.Students
{
    public class IndexModel : StudentsPage
    {
        public IndexModel(IStudentsRepository StudentsRepository, ISchoolsRepository schoolsRepository) : base(StudentsRepository, schoolsRepository)
        {
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
