using System;
using System.Reflection;
using FluentPro.FluentPS.CodeGenerator.Operations;

namespace FluentPro.FluentPS.CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: FluentPro.FluentPS.CodeGenerator.exe <Operation>");
                return;
            }

            var operationName = args[0];
            var operationTypeName = string.Format("{0}.Operations.{1}.Main", typeof(Program).Namespace, operationName);
            var operationType = Assembly.GetExecutingAssembly().GetType(operationTypeName);
            if (operationType == null)
            {
                Console.WriteLine("There is no such operation defined.");
                return;
            }

            var operation = Activator.CreateInstance(operationType) as IOperation;
            if (operation == null)
            {
                Console.WriteLine("Operation can not be constructed.");
                return;
            }

            operation.Run(args);
        }
    }
}
