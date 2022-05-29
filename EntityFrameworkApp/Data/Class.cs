namespace EntityFrameworkApp.Data
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        //bir sınıfta verilen dersler olmalı.
        public ICollection<Course> Courses { get; set; }



    }
}
