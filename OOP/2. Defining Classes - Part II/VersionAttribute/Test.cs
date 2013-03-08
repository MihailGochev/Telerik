//Apply the version attribute to a sample class and display its version at runtime.
namespace VersionAttribute
{
    using System;

    [Version(1.44)]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Class version: {0}. ", attr.Version);
            }

        }
    }
}
