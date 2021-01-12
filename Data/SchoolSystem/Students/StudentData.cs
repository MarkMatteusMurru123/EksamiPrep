using System;
using Data.Abstractions;

namespace Data.SchoolSystem.Students
{
    public sealed class StudentData : DefinedEntityData
    {

        public string SchoolId { get; set; }
        public int Age { get; set; }
        public string FavouriteSubject { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}
