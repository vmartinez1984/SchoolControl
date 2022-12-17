namespace SchoolControl.Core.Dtos
{
    public class GroupCourseDto
    {
        public int Id { get; set; }

        public string PeriodName { get; set; }

        public string GroupName { get; set; }

        public string CourseNames { get;}
    }

    public class GroupCourseDtoIn
    {
        public int PeriodId { get; set; }

        public int GroupId { get; set; }

        public List<int> CourseId { get; set; }
    }

}
