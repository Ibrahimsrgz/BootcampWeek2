using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeAndReflection.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Essential { get; set; }
        public ColumnAttribute(string name, string type, bool essential)
        {
            Name = name;
            Type = type;
            Essential = essential;

        }
        public static void AttributeDisplay(Type classType)
        {

            PropertyInfo[] propertyInfos = classType.GetProperties();

            // for loop to read through all methods

            for (int i = 0; i < propertyInfos.GetLength(0); i++)
            {
                // Creating object array to receive 
                // property attributes returned
                // by the GetCustomAttributes method

                object[] attributesArray = propertyInfos[i].GetCustomAttributes(true);

                // foreach loop to read through 
                // all attributes of the property
                foreach (Attribute item in attributesArray)
                {
                    if (item is ColumnAttribute)
                    {
                        // Display the fields of the NewAttribute
                        ColumnAttribute attributeObject = (ColumnAttribute)item;

                        Console.WriteLine(propertyInfos[i].Name + " tipi " + attributeObject.Type + (attributeObject.Essential == true ? " zorunludur" : " zorunlu değildir"));

                    }
                }
            }
        }

    }
}



