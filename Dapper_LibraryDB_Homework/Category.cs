

namespace Dapper_LibraryDB_Homework;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Category() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\n";
    }
}
