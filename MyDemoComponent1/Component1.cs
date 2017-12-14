using System;

namespace MyDemoComponent1
{
    public class Parameters
    {
        public string prop1 { get; set; }
    }
    public class Component1
    {
        public static String TestMethod(Parameters parameters)
        {
            Console.WriteLine(parameters.prop1);
            return parameters.prop1;
        }
    }
}
