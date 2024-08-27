using System.Reflection;

namespace ReflectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

          
            foreach (Type type in assembly.GetTypes())
            {
                // check if it is InvokeFunction
                var attribute = (InvokeFunction)Attribute.GetCustomAttribute(type, typeof(InvokeFunction));

                if (attribute != null)
                {
                    // get the method name 
                    string methodName = attribute.MethodName;

                    // we find the method in the class
                    MethodInfo methodInfo = type.GetMethod(methodName);

                    if (methodInfo != null && methodInfo.ReturnType == typeof(string) && methodInfo.GetParameters().Length == 0)
                    {
                        
                        object classInstance = Activator.CreateInstance(type);

                        // Invoke the method and get the result
                        string result = (string)methodInfo.Invoke(classInstance, null);

                        
                        Console.WriteLine($"Result from {type.Name}.{methodName}: {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Method {methodName} not found or invalid in class {type.Name}");
                    }
                }
            }
        }
    }
}