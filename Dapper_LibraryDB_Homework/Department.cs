

namespace Dapper_LibraryDB_Homework;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Department() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\n";
    }
}
