using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Facade.Abstractions;

namespace Facade.Students
{
    public sealed class StudentView : DefinedEntityView
    {
        [Required]
        [DisplayName("Kool")]
        public string SchoolId { get; set; }
        [Required]
        [DisplayName("Vanus")]
        public int Age { get; set; }
        [DisplayName("Lemmikaine")]
        public string FavouriteSubject { get; set; }
        [Required]
        [DisplayName("Alustas õppimist")]
        public DateTime EnrollmentDate { get; set; }
        public string GetId()
        {
            return Id;
        }
    }
}
