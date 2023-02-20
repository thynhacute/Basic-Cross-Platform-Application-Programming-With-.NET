namespace ModelEntity.Entities;

public class Person
{
    //1. Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public short Dob { get; set; }
    //2. Constructors
    public Person() { }
    public Person(int id, string name, string address, short dob)
    {
        Id = id;
        Name = name;
        Address = address;
        Dob = dob;
    }
    /*3. manual methods*/
    public override string? ToString()
        => $"Id: {Id}, Name: {Name}, Address:{Address} and Date of birth: {Dob}"; 
    
}