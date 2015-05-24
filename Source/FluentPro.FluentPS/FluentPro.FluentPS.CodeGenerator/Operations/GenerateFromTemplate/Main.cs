using System;
using System.Collections.Generic;
using System.Linq;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Templates;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Network;

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

            var pwaService = PsiContext.Get<IPwa>(pwaUri);
            var viewDs = pwaService.Invoke(p => p.ViewGetAllPortfolioFieldsAndTypesTyped());
            var projectDt = new ProjectDataSet.ProjectDataTable();

            var nativeFields = viewDs.ViewFields.Cast<ViewFieldsDataSet.ViewFieldsRow>()
                .Where(v => !v.IsWFIELD_NAME_SQLNull())
                .Where(v => projectDt.Columns.Contains(v.WFIELD_NAME_SQL))
                .ToList();

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
