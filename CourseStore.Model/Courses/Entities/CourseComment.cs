using CourseStore.Model.Framework;

namespace CourseStore.Model.Courses.Entities;

public class CourseComment : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string CommentBy { get; set; }
    public DateTime CommentDate { get; set; }
    public bool IsApproved { get; set; }
    public string Comment { get; set; }
}
