// track

namespace LessonsFor.DB.DBContent
{
    public class StudentService
    {
        public void Add (string name , string FirstName , string GroupName )
        {
            using MyContentDBContext dbContext = new MyContentDBContext ();


            Student student = new Student ();
            student.Name = name;
            student.FirstName = FirstName;
            student.GroupName = GroupName;
            
            dbContext.Students.Add ( student );
            dbContext.SaveChanges ();
        }

    }
}
