namespace ZombieSurvivors
{
    public class Equipment
    {
        public string Location { get; private set; }
        public string Name { get; private set; }
        public Equipment(string location, string name)
        {
            Location = location;
            Name = name;
        }
    }
}