using System;
using System.Text;

namespace P02_Book_Shop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public string Author
        {
            get => author;
            set
            {
                var names = value.Split();
                if (names.Length > 1 && char.IsNumber(names[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {GetType().Name}");
            sb.AppendLine($"Title: {Title}");
            sb.AppendLine($"Author: {Author}");
            sb.Append($"Price: {Price:F2}");

            return sb.ToString();
        }
    }
}
