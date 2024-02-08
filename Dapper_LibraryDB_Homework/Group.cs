

namespace Dapper_LibraryDB_Homework;

public class Group
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int FacultyId { get; set; }
    public Group() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\nFaculty Id => {FacultyId}\n";
    }

}
