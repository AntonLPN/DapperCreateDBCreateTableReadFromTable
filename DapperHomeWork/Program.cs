using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;


namespace DapperHomeWork
{


    public class Author
    {
        public Author()
        {

        }

        public int Id { get; set; }
       
        public string FirstName { get; set; }
     
        public string LastName { get; set; }


    }







    class Program
    {
       

        static void Main(string[] args)
        {
            //Создание баззы данных
            //using (SqlConnection connection=new SqlConnection((@"Data Source = (localdb)\MSSQLLocalDB;  Integrated Security = SSPI;")))
            //{
            //    connection.Open();

            //    connection.Query("CREATE DATABASE LibraryDaper");
            //}

            //Создание таблицы
            //using (SqlConnection connection = new SqlConnection((@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=LibraryDaper;  Integrated Security = SSPI;")))
            //{
            //    connection.Open();


            //    connection.Query("CREATE TABLE  Authors (Id int IDENTITY(1,1) PRIMARY KEY,FirstName nvarchar(20) NOT NULL,LastName nvarchar(20) NOT NULL )");

            //}


            //Заполнение таблицы
            //using (SqlConnection connection = new SqlConnection((@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=LibraryDaper;  Integrated Security = SSPI;")))
            //{
            //    connection.Open();

            //    List<Author> authors = new List<Author>()
            //    {
            //        new Author() {  FirstName = "myfirstname1", LastName = "mylastname1" },
            //        new Author() {  FirstName = "myfirstname2", LastName = "mylastname2" },
            //        new Author() {  FirstName = "myfirstname3", LastName = "mylastname3" }
            //    };
            //    connection.Insert(authors);


            //}

            //вывод значения таблицы

            using (SqlConnection connection = new SqlConnection((@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=LibraryDaper;  Integrated Security = SSPI;")))
            {
                connection.Open();

                var listAuthors = connection.GetAll<Author>().ToList();

                foreach (var item in listAuthors)
                {
                    Console.WriteLine("{0}  {1}  {2}",item.Id,item.FirstName,item.LastName);
                }

               
            }


        }
    }
}
