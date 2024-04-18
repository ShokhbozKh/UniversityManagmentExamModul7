namespace PDP_Examp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public virtual ICollection<Category>? Children { get; set; }
        public virtual ICollection<Course> Courses { get;}

        public Category()
        {
            Courses = new List<Course>();
            Children = new List<Category>();
        }
    }
}
