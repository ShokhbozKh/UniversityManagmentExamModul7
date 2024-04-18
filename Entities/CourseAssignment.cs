namespace PDP_Examp.Entities
{
    public class CourseAssignment
    {
        public int Id { get; set; }
        public string Room { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public CourseAssignment()
        {
            
            Enrollments = new List<Enrollment>();
        }

    }
}
