using System;
using System.Collections.Generic;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Templates;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate
{
    public class Main : IOperation
    {
        public void Help()
        {
            Console.WriteLine("<Template>   : Template name to use.");
            Console.WriteLine("<Output>     : Output file name.");
            Console.WriteLine();

            Console.WriteLine("Templates    : NativeFieldsList");
        }

        public void Run(string[] args)
        {
            var pwaUri = new Uri(args[1]);

            var projectDt = new ProjectDataSet.ProjectDataTable();
            var template = new NativeFieldsListTemplate
            {
                Session = new Dictionary<string, object>
                {
                    {"projectDt", projectDt}
                }
            };

            Console.WriteLine(template.TransformText());
        } 
    }
}
