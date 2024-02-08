

using System.Text.RegularExpressions;

namespace Dapper_LibraryDB_Homework;

public class Teacher
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int DepartmentId { get; set; }
    public Teacher() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nFirst Name => {FirstName}\nLast Name => {LastName}\nDepartment Id => {DepartmentId}\n";
    }
}
