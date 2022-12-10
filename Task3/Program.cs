﻿//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити клас Book. Створити класи Title, Author та Content, кожен з 
//    яких повинен містити одне рядкове поле та метод void Show(). 
//    Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. 
//    Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Content content = new Content();
            content.TextContent = "...TextContent...";
            Author author = new Author();
            author.TextAuthor = "...TextAuthor...";
            Title title = new Title();
            title.TextTitle = "...TextTitle...";

            Book book = new Book(title, content, author);
        }
    }
}