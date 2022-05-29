using AttributeAndReflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeAndReflection
{
    [Table("öğrenci")]
    public class Student
    {

        [Column("Id", "int", true)]
        public int Id { get; set; }

        [Column("Name", "string", false)]
        public string Name { get; set; }

        [Column("Surname", "string", true)]
        public string Surname { get; set; }


    }
}
