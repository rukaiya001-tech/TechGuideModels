using System.ComponentModel.DataAnnotations;

namespace TechGuide.Models
{
    public class CoursePrerequisites
    {
       public int CourseID { get; set; }
        public int PrerequisiteID { get; set; }
        public Course course { get; set; }
        public Course Prerequisite { get; set; }
    }
}
