namespace VegardNet.CSharpForJavaDevelopers.Interfaces
{
    class Teacher : IReportable
    {
        public void GenerateReport()
        {
            System.Console.WriteLine("I'm a teacher report.");
        }
    }
}
