using System;
using System.Reflection;

/* Папкин Игорь
 * С помощью рефлексии выведите все свойства структуры DateTime*/

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Type dateTimeProperties = typeof(DateTime);
            PropertyInfo[] propertyInfos = dateTimeProperties.GetProperties();

            foreach(PropertyInfo pi in propertyInfos)
            {
                Console.WriteLine($"{pi}");
            }
        }
    }
}
