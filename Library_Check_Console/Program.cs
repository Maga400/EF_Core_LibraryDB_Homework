
using Library_DataAccessLayer.Repostories.Concretes;
using Library_Model.Entities;

Console.WriteLine("Hello, World!");

//var authors = new AuthorRepository();
//var author = new Author();
//author.FirstName = "Mehemmed";
//author.LastName = "Hemzeyev";

//authors.Add(author);
//authors.Save();

//authors.ShowAuthors();

var themes = new ThemeRepository();
//var theme = new Theme();
//theme.Name = "Huseyn";
//themes.Add(theme);
//themes.Save();

foreach(var t in themes.GetAll()) 
{
    Console.WriteLine(t.Name);
}