namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            var student = new Student
            {
                FirstName = "Youssef",
                LastName = "Ashraf",
                Email = "youssefashraf@gmail.com"
            };

            context.students.Add(student);
            context.SaveChanges();

            var department = new Department
            {
                DepartmentName = "CS"
            };

            context.departments.Add(department);
            context.SaveChanges();




            var grade = new Grade
            {
                GradeName = "Level 2"
            };
            context.grades.Add(grade);
            context.SaveChanges();

            var teacher = new Teacher
            {
                TeacherName = "Mohamed Ibrahim",
                DepartmentId = department.DepartmentId
            };

            context.teachers.Add(teacher);
            context.SaveChanges();


            var course = new Course
            {
                CourseName = ".NET",
                CourseCredits = 3,
                TeacherId = teacher.TeacherId
            };

            context.courses.Add(course);
            context.SaveChanges();


            context.enrollments.Add(new Enrollment { StudentId = 1, CourseId = 1, GradeId = 1 });
            context.enrollments.Add(new Enrollment { StudentId = 2, CourseId = 2, GradeId = 1 });
            context.SaveChanges();


            var enrollment = new Enrollment
            {
                StudentId = 1,
                CourseId = 1,
                GradeId = 1
            };


            var enrollment1 = new Enrollment
            {
                StudentId = 2,
                CourseId = 2,
                GradeId = 2
            };

            context.enrollments.Add(enrollment);
            context.SaveChanges();

            context.enrollments.Add(enrollment1);
            context.SaveChanges();


        }
    }
}
