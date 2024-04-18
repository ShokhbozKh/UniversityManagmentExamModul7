namespace PDP_Examp.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CourseAssignmentId { get; set; }
        public CourseAssignment? CourseAssignment { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
