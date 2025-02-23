// See https://aka.ms/new-console-template for more information

// Reflection
// Debug Tool

using System.Reflection;

Type t1=DateTime.Now.GetType();

Type t2 = typeof(DateTime[]);

Type t3=typeof(Dictionary<string, object>);

Console.WriteLine(t3);

Type strType=typeof(string);

string name=strType.Name;
Console.WriteLine(name);

var bType=strType.BaseType;
Console.WriteLine(bType);

var aType = strType.Assembly;
Console.WriteLine(aType);

bool isPublic=strType.IsPublic;
Console.WriteLine(isPublic);

Type customType = Assembly.GetExecutingAssembly().GetType("ITC.Person");
Console.WriteLine(customType);


namespace ITC
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

// fit in Memory
// partition

// DS ( Collection )
// DSA ( Linear, Binary )