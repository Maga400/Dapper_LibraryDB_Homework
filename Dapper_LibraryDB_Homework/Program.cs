
using Dapper;
using Dapper_LibraryDB_Homework;
using System.Data.SqlClient;

string? connectionStr = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

var connection = new SqlConnection(connectionStr);
connection.Open();



//-------------------------------------------------------SELECT---------------------------------------------------------

//-----------------------------------------------1---------------------------------------------------
//string? query1 = "SELECT * FROM Themes";
//IEnumerable<Theme> themes = connection.Query<Theme>(query1);

//foreach (var theme in themes)
//{
//    Console.WriteLine(theme.ToString());
//}

//-----------------------------------------------2---------------------------------------------------
//string? query2 = "SELECT * FROM Authors";
//IEnumerable<Author> authors = connection.Query<Author>(query2);

//foreach (var author in authors)
//{
//    Console.WriteLine(author.ToString());
//}

//-----------------------------------------------3---------------------------------------------------
//string? query3 = "SELECT * FROM Books";
//IEnumerable<Book> books = connection.Query<Book>(query3);

//foreach (var value in books)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------4---------------------------------------------------
//string? query4 = "SELECT * FROM Categories";
//IEnumerable<Category> categories = connection.Query<Category>(query4);

//foreach (var value in categories)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------5---------------------------------------------------
//string? query5 = "SELECT * FROM Departments";
//IEnumerable<Department> departments = connection.Query<Department>(query5);

//foreach (var value in departments)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------6---------------------------------------------------
//string? query6 = "SELECT * FROM Faculties";
//IEnumerable<Faculty> faculties = connection.Query<Faculty>(query6);

//foreach (var value in faculties)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------7---------------------------------------------------
//string? query7 = "SELECT * FROM Groups";
//IEnumerable<Group> groups = connection.Query<Group>(query7);

//foreach (var value in groups)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------8---------------------------------------------------
//string? query8 = "SELECT * FROM Libs";
//IEnumerable<Lib> libs = connection.Query<Lib>(query8);

//foreach (var value in libs)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------9---------------------------------------------------
//string? query9 = "SELECT * FROM Press";
//IEnumerable<Pres> press = connection.Query<Pres>(query9);

//foreach (var value in press)
//{
//    Console.WriteLine(value.ToString());
//}

//-----------------------------------------------10---------------------------------------------------
//string? query10 = "SELECT * FROM S_Cards";
//IEnumerable<SCard> scards = connection.Query<SCard>(query10);

//foreach (var value in scards)
//{
//    Console.WriteLine(value.ToString());
//}

//-------------------------------------------------------INSERT---------------------------------------------------------

//-----------------------------------------------1---------------------------------------------------
//string? query1 = "INSERT INTO Authors(Id,FirstName,LastName) VALUES(40,'Mehemmed','Hemzeyev')";
//connection.Execute(query10);

//-----------------------------------------------2---------------------------------------------------
//string? query2 = "INSERT INTO Categories(Id,Name) VALUES(15,'Proqramlasdirma')";
//connection.Execute(query2);

//-----------------------------------------------3---------------------------------------------------
//string? query3 = "INSERT INTO Departments(Id,Name) VALUES(5,'IT')";
//connection.Execute(query3);

//-----------------------------------------------4---------------------------------------------------
//string? query4 = "INSERT INTO Faculties(Id,Name) VALUES(5,'Design')";
//connection.Execute(query4);

//-----------------------------------------------5---------------------------------------------------
//string? query5 = "INSERT INTO Groups(Id,Name,Id_Faculty) VALUES(11,'FBAS',2)";
//connection.Execute(query5);

//-----------------------------------------------6---------------------------------------------------
//string? query6 = "INSERT INTO Libs(Id,FirstName,LastName) VALUES(3,'Teymur','Haqverdiyev')";
//connection.Execute(query6);

//-----------------------------------------------7---------------------------------------------------
//string? query7 = "INSERT INTO Press(Id,Name) VALUES(12,'Fateh')";
//connection.Execute(query7);

//-----------------------------------------------8---------------------------------------------------
//string? query8 = "INSERT INTO Themes(Id,Name) VALUES(10,'Suleyman')";
//connection.Execute(query8);

//-----------------------------------------------9---------------------------------------------------
//string? query9 = "INSERT INTO Students(Id,FirstName,LastName,Id_Group,Term) VALUES(30,'Xan','Memmedov',2,94)";
//connection.Execute(query9);

//-----------------------------------------------10---------------------------------------------------
//string? query10 = "INSERT INTO Teachers(Id,FirstName,LastName,Id_Dep) VALUES(30,'Aqsin','Salehov',1)";
//connection.Execute(query10);

//-------------------------------------------------------UPDATE---------------------------------------------------------

//-----------------------------------------------1---------------------------------------------------
//string? query1 = "UPDATE Authors SET FirstName = 'Mehemmed'  WHERE Id = 2";
//connection.Execute(query1);

//-----------------------------------------------2---------------------------------------------------
//string? query2 = "UPDATE Books SET Pages = 5000  WHERE Id = 4";
//connection.Execute(query2);

//-----------------------------------------------3---------------------------------------------------
//string? query3 = "UPDATE Categories SET Name = 'STEP' WHERE Id = 3";
//connection.Execute(query3);

//-----------------------------------------------4---------------------------------------------------
//string? query4 = "UPDATE Departments SET Name = 'Kiber' WHERE Id = 5";
//connection.Execute(query4);

//-----------------------------------------------5---------------------------------------------------
//string? query5 = "UPDATE Faculties SET Name = 'Alqoritm'  WHERE Id = 1";
//connection.Execute(query5);

//-----------------------------------------------6---------------------------------------------------
//string? query6 = "UPDATE Groups SET Id_Faculty = 3 WHERE Id = 2";
//connection.Execute(query6);

//-----------------------------------------------7---------------------------------------------------
//string? query7 = "UPDATE Libs SET LastName = 'Ivanov'  WHERE Id = 3";
//connection.Execute(query7);

//-----------------------------------------------8---------------------------------------------------
//string? query8 = "UPDATE Press SET Name = 'Catarina'  WHERE Id = 7";
//connection.Execute(query8);

//-----------------------------------------------9---------------------------------------------------
//string? query9 = "UPDATE S_Cards SET Id_Student = 22  WHERE Id = 8";
//connection.Execute(query9);

//-----------------------------------------------10---------------------------------------------------
//string? query10 = "UPDATE Themes SET Name = 'Leyla'  WHERE Id = 5";
//connection.Execute(query10);

//-------------------------------------------------------DELETE---------------------------------------------------------

//-----------------------------------------------1---------------------------------------------------
//string? query1 = "DELETE S_Cards WHERE Id = 2";
//connection.Execute(query1);

//-----------------------------------------------2---------------------------------------------------
//string? query2 = "DELETE S_Cards WHERE Id_Student = 5";
//connection.Execute(query2);

//-----------------------------------------------3---------------------------------------------------
//string? query3 = "DELETE S_Cards WHERE Id_Lib = 1";
//connection.Execute(query3);

//-----------------------------------------------4---------------------------------------------------
//string? query4 = "DELETE T_Cards WHERE Id = 5";
//connection.Execute(query4);

//-----------------------------------------------5---------------------------------------------------
//string? query5 = "DELETE T_Cards WHERE Id_Teacher = 3";
//connection.Execute(query5);

//-----------------------------------------------6---------------------------------------------------
//string? query6 = "DELETE T_Cards WHERE Id_Book = 13";
//connection.Execute(query6);

//-----------------------------------------------7---------------------------------------------------
//string? query7 = "DELETE T_Cards WHERE Id_Lib = 2";
//connection.Execute(query7);

//-----------------------------------------------8---------------------------------------------------
//string? query8 = "DELETE S_Cards WHERE Id_Book = 3";
//connection.Execute(query8);

//-----------------------------------------------9---------------------------------------------------
//string? query9 = "DELETE S_Cards WHERE Id_Lib = 2";
//connection.Execute(query9);

//-----------------------------------------------10---------------------------------------------------
//string? query10 = "DELETE T_Cards WHERE Id < 5";
//connection.Execute(query10);

