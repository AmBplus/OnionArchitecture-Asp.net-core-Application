namespace Server.Domian;

public interface IPersonRepository
{
    void AddPerson(Person person);
    void RemovePerson(Person person);
    Person GetPersonById(int id);
    List<Person> GetAll();
}