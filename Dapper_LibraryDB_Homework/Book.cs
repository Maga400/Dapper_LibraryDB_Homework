

using System.ComponentModel;

namespace Dapper_LibraryDB_Homework;

public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public string? Comment { get; set; }
    public int Quantity { get; set; }
    public int ThemeId { get; set; }
    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public int PresId { get; set; }
    public Book() 
    {
    
    }
    public override string ToString()
    {
        return $"Id => {Id}\nName => {Name}\nPages => {Pages}\nYear Press => {YearPress}\nComment => {Comment}\nQuantity => {Quantity}\n" +
            $"Theme Id => {ThemeId}\nCategory Id => {CategoryId}\nAuthor Id => {AuthorId}\nPres Id => {PresId}\n";
    }

}
