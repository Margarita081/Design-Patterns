using System;
using System.Reflection;

namespace Task1.Task_1_3
{
    internal class Program
    {
        static void Main()
        {
            var myAssembly = Assembly.LoadFrom(@"C:\DesighnPattern\Multithread\Task1\bin\Debug\net8.0\Task1.dll");

            //task1
            try
            {
                Console.WriteLine("Enter full name of a class: ");
                string classFullName = Console.ReadLine();

                Console.WriteLine("Enter name of a method: ");
                string classNameMethod = Console.ReadLine();

                Console.WriteLine("Enter arguments separated by commas.");
                string argu = Console.ReadLine();

                string[] argString = string.IsNullOrWhiteSpace(argu)
                    ? Array.Empty<string>()
                    : argu.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                Type type = myAssembly.GetType(classFullName, throwOnError: false);
                if (type == null)
                {
                    throw new Exception("The class not found.");
                }

                object instance = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod(classNameMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                if (method == null)
                {
                    throw new Exception("A Method not found");
                }

                ParameterInfo[] parameters = method.GetParameters();

                if (parameters.Length != argString.Length)
                {
                    throw new Exception("The number of arguments doesn't match with the number in the method.");
                }

                object[] convertedArgu = new object[parameters.Length];

                for (int i = 0; i < convertedArgu.Length; i++)
                {
                    Type paramType = parameters[i].ParameterType;
                    convertedArgu[i] = Convert.ChangeType(argString[i], paramType);
                }

                object result = method.Invoke(instance, convertedArgu);

                if (method.ReturnType != typeof(void))
                {
                    Console.WriteLine($"Result: {result}.");
                }
                else
                {
                    Console.WriteLine("The method completed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }

            Console.WriteLine("Enter any key to exit from task 1.");
            Console.ReadLine();

            //task2
            Console.WriteLine("A list of the classes and their properties: ");

            foreach (Type type in myAssembly.GetTypes())
            {
                if (!type.IsClass)
                    continue;

                if (type.Name.Contains("<"))
                    continue;

                Console.WriteLine($"The class: {type.FullName}");

                var properties = type.GetProperties(
                    BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.Static);

                if (properties.Length == 0)
                {
                    Console.WriteLine("   no properties.");
                    continue;
                }

                foreach (var proper in properties)
                {
                    string access = GetAccessModifier(proper);
                    string modifiers = GetPropertyModifiers(proper);

                    Console.WriteLine($"   {access} {modifiers}{proper.PropertyType.Name} {proper.Name}");
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Press any key to exit from task 2.");
            Console.ReadKey();

            //task 3

            try
            {
                Console.WriteLine("Enter class name: ");
                string className3 = Console.ReadLine();

                Type type3 = myAssembly.GetType(className3, throwOnError: false);
                if (type3 == null)
                    throw new Exception("Class not found.");

                object instance3 = Activator.CreateInstance(type3);

                MethodInfo createMethod = type3.GetMethod("Create", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (createMethod == null)
                    throw new Exception("Create method not found.");

                ParameterInfo[] createParams = createMethod.GetParameters();
                object[] createArgs = new object[createParams.Length];

                Console.WriteLine("Enter parameters for Create:");

                for (int i = 0; i < createParams.Length; i++)
                {
                    Console.Write($"{createParams[i].Name} ({createParams[i].ParameterType.Name}): ");
                    string input = Console.ReadLine();
                    createArgs[i] = Convert.ChangeType(input, createParams[i].ParameterType);
                }

                createMethod.Invoke(instance3, createArgs);

                MethodInfo printMethod = type3.GetMethod("PrintObject", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (printMethod == null)
                    throw new Exception("PrintObject method not found.");

                object result3 = printMethod.Invoke(instance3, null);

                Console.WriteLine("\nPrintObject result:");
                Console.WriteLine(result3?.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Task 3 error: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string GetAccessModifier(PropertyInfo proper)
        {
            var getMethod = proper.GetGetMethod(true);
            var setMethod = proper.GetSetMethod(true);

            if (getMethod == null && setMethod == null)
                return "unknown";

            string getAccess = GetMethodAccess(getMethod);
            string setAccess = GetMethodAccess(setMethod);

            if (getAccess != setAccess)
                return $"[{getAccess} get, {setAccess} set]";

            return getAccess;
        }

        static string GetMethodAccess(MethodInfo method)
        {
            if (method == null)
            {
                return "none";
            }

            if (method.IsPublic)
            {
                return "public";
            }
            if (method.IsPrivate)
            {
                return "private";
            }
            if (method.IsFamily)
            {
                return "protected";
            }
            if (method.IsAssembly)
            {
                return "internal";
            }
            if (method.IsFamilyOrAssembly)
            {
                return "protected internal";
            }

            return "private";
        }

        static string GetPropertyModifiers(PropertyInfo proper)
        {
            return proper.GetGetMethod(true)?.IsStatic == true ? "static " : "";
        }
    }
}
