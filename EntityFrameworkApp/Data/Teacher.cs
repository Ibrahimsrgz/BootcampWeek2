namespace EntityFrameworkApp.Data
{
    public class Teacher
    {
        public int Id { get; set; }

        public string TeacherName { get; set; }


        //Her öğretmen sadece tek derse girmeli 
        public Course  Course { get; set; }

    }
}
