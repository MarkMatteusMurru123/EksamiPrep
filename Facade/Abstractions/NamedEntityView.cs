﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Facade.Abstractions
{
    public abstract class NamedEntityView : UniqueEntityView
    {
        [Required]
        [DisplayName("Nimi")]
        public string Name { get; set; }
    }
}
