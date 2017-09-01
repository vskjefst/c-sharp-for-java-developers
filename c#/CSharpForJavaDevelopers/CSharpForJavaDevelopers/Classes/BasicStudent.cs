namespace VegardNet.CSharpForJavaDevelopers.Classes
{
    public class BasicStudent
    {
        private string name;

        public BasicStudent(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
