using System.Collections.Generic;

namespace VegardNet.CSharpForJavaDevelopers.Interfaces
{
    class ReportGenerator
    {
        public void Main(string[] args)
        {
            new List<IReportable>() { new Student(), new Teacher() }.ForEach(r => r.GenerateReport());
            System.Console.ReadKey();
        }
    }
}
