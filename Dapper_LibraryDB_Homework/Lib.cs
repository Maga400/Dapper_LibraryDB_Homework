

using System.Xml.Linq;

namespace Dapper_LibraryDB_Homework;

public class Lib
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public Lib() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nFirst Name => {FirstName}\nLast Name => {LastName}\n";
    }
}
