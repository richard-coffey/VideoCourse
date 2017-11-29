using System.Collections.Generic;
using VideoCourse.Models.DTOModels;

namespace VideoCourse.Models.MembershipViewModels
{
    public class DashboardViewModel
    {
        public List<List<CourseDTO>> Courses { get; set; }
    }
}
