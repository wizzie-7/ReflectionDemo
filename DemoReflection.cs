using System;
using System.Reflection;

namespace ReflectionDemo
{
    class DemoReflection
    {
        static void Main(string[] args)
        {
            System.Type t = typeof(Employee);

            

            MethodInfo[] methods = t.GetMethods();
            PropertyInfo[] properties = t.GetProperties();
            FieldInfo[] fields = t.GetFields();

            Console.WriteLine("Employee class has following Methods");
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("Employee class has following Properties");
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("Employee class has following Fields");
            foreach(FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }
    }
    public class Employee
    {
        public int num;
        public string str;
        public int Age
        {
            get { return num; }
            set { num = value; }
        }
        public string Str
        {
            get { return str; }
            set { str = value; }
        }
        public string GetName()
        {
            return str;
        }
        public int GetNum()
        {
            return num;
        }
    }
}
