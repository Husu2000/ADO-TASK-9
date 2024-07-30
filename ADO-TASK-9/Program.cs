using ADO_TASK_9;
using System.Data.SqlClient;

IAuthorRepository repo = new AuthorRepository(new SqlConnection(),
    @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");

//var author = repo.Add(new Author() { FirstName = "Neil", LastName = "Gaiman" });
//var author2 = repo.Add(new Author() { FirstName = "Zahid", LastName = "Xelil" });
//Console.WriteLine(author2);

//Console.WriteLine(repo.GetById(13));
//repo.Remove(18);
repo.UpdateAuthors(new List<Author>() {
    new Author() {Id=20, FirstName = "ib", LastName = "talib" },
new Author() {Id=21 ,FirstName = "hus", LastName = "meme" },
new Author() {Id=22, FirstName = "mag", LastName = "fetu" }
    }) ;
repo.RemoveByIdArray([15, 16, 17]);
repo.GetAll().ToList().ForEach(Console.WriteLine);
