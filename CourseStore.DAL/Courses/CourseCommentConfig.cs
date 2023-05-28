using CourseStore.Model.Courses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Courses;

public class CourseCommentConfig : IEntityTypeConfiguration<CourseComment>
{
    public void Configure(EntityTypeBuilder<CourseComment> builder)
    {
        builder.Property(comment => comment.CommentBy).IsRequired().HasMaxLength(100);
        builder.Property(comment => comment.Comment).IsRequired().HasMaxLength(1000);
    }
}
