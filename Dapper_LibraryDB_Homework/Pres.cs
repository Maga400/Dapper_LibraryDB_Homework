

namespace Dapper_LibraryDB_Homework;

public class Pres
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Pres() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\n";
    }
}
