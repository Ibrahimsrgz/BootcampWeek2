
using AttributeAndReflection;
using AttributeAndReflection.Attributes;
using System;
using System.Linq;
using System.Reflection;

Student student = new Student();

Validate(student);

ColumnAttribute.AttributeDisplay(typeof(Student));

//validation burada devreye giriyor artık class isminin türkçe ve özel karakter
//içerip içermediğini burada kontrol edeceğim

bool Validate(Student student)
{
    Type type = typeof(Student);

    TableAttribute attr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));

    bool check = ContainsUnicodeCharacter(attr.Name);

    if (check == false) {
        Console.WriteLine("Tablo adı: " + attr.Name);
        return true;
    }
      
    else
        throw new Exception($"{attr.Name} olarak gönderilen tablo ismi türkçe veya özel karakter içeriyor.");
}


//burda amacım eğer ascii kodu 255 i geçen varsa uyarı vermek olacak. 
bool ContainsUnicodeCharacter(string input)
{
    const int MaxAnsiCode = 255;

    return input.Any(c => c > MaxAnsiCode);
}