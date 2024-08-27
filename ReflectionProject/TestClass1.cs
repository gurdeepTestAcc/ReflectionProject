namespace ReflectionProject
{
   // This class is marked with the InvokeFunction attribute, specifying "WriteHi" as the method to be invoked.
    [InvokeFunction("WriteHi")]
    public class TestClass1
    {
        public string WriteHi()
        {
            return "Hi from TestClass1!";
        }
    }
}
