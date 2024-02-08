

using System.Xml.Linq;

namespace Dapper_LibraryDB_Homework;

public class SCard
{
    public int Id { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int StudentId { get; set; }
    public int BookId { get; set; }
    public int LibId { get; set; }
    public SCard() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nDate Out => {DateOut}\nDate In => {DateIn}\nStudent Id => {StudentId}\nBook Id => {BookId}\nLib Id => {LibId}\n";
    }
}
