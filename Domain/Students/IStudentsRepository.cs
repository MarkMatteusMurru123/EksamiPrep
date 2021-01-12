using System;
using System.Collections.Generic;
using System.Text;
using Domain.Abstractions;

namespace Domain.Students
{
    public interface IStudentsRepository : IRepository<Student> { }
    
}
