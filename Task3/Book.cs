using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Book
    {
        public Book(Title title, Content content, Author author)
        {
            title.Show();
            content.Show();
            author.Show();
        }
    }
}
