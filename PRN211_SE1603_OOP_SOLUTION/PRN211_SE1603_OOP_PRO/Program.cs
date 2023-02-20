using Repository.Manager;
using ModelEntity.Entities;
namespace Prn211.Oop;
public class Program
{
    public static void Main(string[] args)
    {
        ManagerPerson managerPerson= new ManagerPerson();
        //1. Khai bao 3 person (employee) 
        Employee e1 = new Employee(25, 250000, 1, "Bui Huu Dong",
            "Quan 10, TPHCM", 1982);
        Employee e2 = new Employee(30, 350000, 2, "Ma Van Meo",
            "Quan 11, TPHCM", 1983);

        Employee e3 = new Employee(20, 350000, 3, "Ma Van Meo",
            "Quan 11, TPHCM", 1983);

        //2. Ddd vao he thong
        managerPerson.AddPerson(e1);
        managerPerson.AddPerson(e2);
        managerPerson.AddPerson(e3);
        //3. Display

        managerPerson.Display();
        Console.ReadLine();

    }
}