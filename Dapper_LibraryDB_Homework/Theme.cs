

namespace Dapper_LibraryDB_Homework;

public class Theme
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Theme() 
    {
    
    }

    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}";
    }

}
