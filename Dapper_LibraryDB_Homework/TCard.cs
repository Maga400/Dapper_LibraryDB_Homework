

namespace Dapper_LibraryDB_Homework;

public class TCard
{
    public int Id { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int TeacherId { get; set; }
    public int BookId { get; set; }
    public int LibId { get; set; }
    public TCard() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nDate Out => {DateOut}\nDate In => {DateIn}\nTeacher Id => {TeacherId}\nBook Id => {BookId}\nLib Id => {LibId}\n";
    }

}
