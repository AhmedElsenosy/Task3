using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Configuration
{
    public class EnrollmentConfig : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasOne(x => x.student).WithMany(x => x.enrollments).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.course).WithMany(x => x.enrollments).HasForeignKey(x => x.CourseId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.grade).WithOne(x => x.enrollment).HasForeignKey<Enrollment>( x => x.GradeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
