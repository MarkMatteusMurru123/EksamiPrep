using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Facade.Abstractions;

namespace Facade.SchoolSystem.Schools
{
    public sealed class SchoolView : DefinedEntityView
    {
        [Required]
        [DisplayName("Kooli tüüp")]
        public string Type { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DisplayName("Aadress")]
        public string Address { get; set; }

        public string GetId()
        {
            return Id;
        }


    }
}
