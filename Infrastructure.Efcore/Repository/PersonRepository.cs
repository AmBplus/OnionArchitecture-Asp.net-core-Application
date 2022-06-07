using Server.Domian;

namespace server.Infrastructure.Efcore.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly PersonContext _context;

    public PersonRepository(PersonContext context)
    {
        _context = context;
    }

    public void AddPerson(Person person)
    {
        _context.Add(person);
    }

    public void RemovePerson(Person person)
    {
        _context.Remove(person);
    }

    public Person? GetPersonById(int id)
    {
        return _context.People.FirstOrDefault(x => x.Id == id);
    }

    public List<Person>? GetAll()
    {
        return _context.People?.ToList();
    }
}