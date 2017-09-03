namespace VegardNet.CSharpForJavaDevelopers.Interfaces
{
    class Student : IReportable
    {
        public void GenerateReport()
        {
            System.Console.WriteLine("I'm a student report.");
        }
    }
}
