

using ModelEntity.Entities;

namespace Repository.Manager;
public class ManagerPerson
{
    public IRepository<Person> Repository { get; set; }

    public ManagerPerson()
    {
        Repository = new RepositoryPerson();
    }

    public ManagerPerson(IRepository<Person> repository)
    {
        Repository = repository;
    }

    public void AddPerson(Person person)
    {
        Repository.Add(person);
    }
    public IList<Person> GetAllPerson() 
        => Repository.GetAll();
    
    public void Display()
    {
        foreach(var p in GetAllPerson()) { 
            Console.WriteLine(p);
        }

    }


}
