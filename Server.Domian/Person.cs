namespace Server.Domian
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            CreatedDate = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Name { get; }
        public DateTime CreatedDate { get; }
    }
}