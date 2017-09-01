namespace VegardNet.CSharpForJavaDevelopers.Classes
{
    class BasicStudent
    {
        private string name;

        public BasicStudent(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
