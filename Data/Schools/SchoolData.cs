﻿using Data.Abstractions;

namespace Data.Schools
{
    public sealed class SchoolData : DefinedEntityData
    {
        public string Type { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
   


    }
}
