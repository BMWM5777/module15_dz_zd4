using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_dz_zd4
{
    class Program
    {
        static void Main()
        {
            Type listType = typeof(List<>);
            Type genericArgument = typeof(int);

            Type constructedListType = listType.MakeGenericType(genericArgument);
            ConstructorInfo[] constructors = constructedListType.GetConstructors();

            Console.WriteLine($"Конструкторы класса List<{genericArgument.Name}>:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
