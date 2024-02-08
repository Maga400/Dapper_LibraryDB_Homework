

using System.Xml.Linq;

namespace Dapper_LibraryDB_Homework;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Term { get; set; }
    public int GroupId { get; set; }
    public Student() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nFirst Name => {FirstName}\nLast Name => {LastName}\nTerm => {Term}\nGroup Id => {GroupId}\n";
    }

}
