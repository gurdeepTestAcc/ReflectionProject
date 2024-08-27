namespace ReflectionProject
{
    // following attribute is used to mark classes with the name of a method that should be invoked.
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class InvokeFunction : Attribute
    {
        public string MethodName { get; }

        public InvokeFunction(string methodName)
        {
            MethodName = methodName;
        }
    }
}
