using CourseStore.Model.Courses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Courses;
public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(course => course.ImageUrl).IsRequired().HasMaxLength(1000);
        builder.Property(course => course.Title).IsRequired().HasMaxLength(100);
        builder.Property(course => course.Description).IsRequired();
        builder.Property(course => course.Description).IsRequired().HasMaxLength(500);
    }
}