using CourseStore.Model.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Teachers;

public class TeacherConfig : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.Property(teacher => teacher.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(teacher => teacher.LastName).IsRequired().HasMaxLength(50);
    }
}
