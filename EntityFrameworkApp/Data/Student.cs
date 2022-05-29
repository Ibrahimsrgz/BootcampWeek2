namespace EntityFrameworkApp.Data
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }


        //Her öğrenci bir okulda bir sınıfta olmalı burda da ben her öğrenci için bir school ve class ı zorunlu tuttum.

        public School School { get; set; }

        public Class Class  { get; set; }
    }
}
