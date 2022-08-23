using AutoMapper;
using CleanArch.Application.Intefaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            this._courseRepository = courseRepository;
            _mapper = mapper;
        }
        public List<CourseViewModel> GetCourses()
        {

            var courses = _courseRepository.GetCourses();
            var viewModelCourses = _mapper.Map<List<CourseViewModel>>(courses);
            return viewModelCourses;
        }
    }
}
