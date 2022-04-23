
using CleanArch.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.ApplicationCore.Intefaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
