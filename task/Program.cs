using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Authorname", "Titlename", "Contentname");
            book.Show();
        }
    }

    class Book
    {
        Author author1;
        Title title1;
        Content content1;
        public Book(string author, string title,string content)
        {
             author1 = new Author(author);
             title1 = new Title(title);
             content1 = new Content(content);
        }

        public void Show()
        {
            author1.Show();
            title1.Show();
            content1.Show();
        }
    }

    class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine($"Author: {author}");
        }
    }

    class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Content: {content}");
        }
    }

    class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {title}");
        }
    }
}
