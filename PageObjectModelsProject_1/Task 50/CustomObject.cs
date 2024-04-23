namespace PageObjectModelsProject_1.Task_50
{
    public class CustomObject
    {
        private string name;
        private string position;
        private string office;

        public CustomObject(string name, string position, string office)
        {
            this.name = name;
            this.position = position;
            this.office = office;
        }

        public string getName()
        {
            return name;
        }

        public string getPosition()
        {
            return position;
        }

        public string getOffice()
        {
            return office;
        }
    }
}
