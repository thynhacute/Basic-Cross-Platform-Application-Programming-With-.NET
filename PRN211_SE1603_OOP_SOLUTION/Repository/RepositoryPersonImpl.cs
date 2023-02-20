using ModelEntity.Entities;

namespace Repository;

public class RepositoryPerson: IRepository<Person>
{
    //fields
    private IList<Person> _persons;

    public RepositoryPerson()
    {
        _persons = new List<Person>();
    }
    //properties
    public IList<Person> Persons => _persons;

    public void Add(Person entity)
    {
        if(entity != null) this._persons.Add(entity);

    }

    public void Delete(Person entity) 
        => this._persons.Remove(entity);
    public void Delete(int id)
    {
        //1. lay object person theo id
        Person p = GetById(id);
        if(p is not null) Delete(p);  
    }

    public List<Person> GetAll() => _persons.ToList();
    

    public Person GetById(int id)
    {
        foreach(Person p in _persons)
        {
            if(p.Id == id) return p;
        }
        return null;
    }

    public void Update(Person entity)
    {
        int index = _persons.IndexOf(entity);
        if (index != -1)
        {
            _persons[index] = entity;
        }

        //local function
        bool chkExist() {
            foreach(Person p in _persons)
            {
                if(p.Id == entity.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }



}