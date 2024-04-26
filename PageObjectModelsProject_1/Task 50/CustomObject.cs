namespace PageObjectModelsProject_1.Task_50
{
    public class CustomObject
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }

        public CustomObject(string name, string position, string office)
        {
            this.Name = name;
            this.Position = position;
            this.Office = office;
        }
    }
}
