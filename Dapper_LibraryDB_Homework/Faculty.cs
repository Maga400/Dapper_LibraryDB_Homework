

namespace Dapper_LibraryDB_Homework;

public class Faculty
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Faculty() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\n";
    }
}
