namespace PDP_Examp.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public virtual ICollection<CourseAssignment> CourseAssignments { get; set; }

        public Instructor()
        {
            CourseAssignments = new List<CourseAssignment>();
        }


    }
}
