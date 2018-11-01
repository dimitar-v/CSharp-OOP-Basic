namespace P02_Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price * 1.3m)
        { }

        //public override decimal Price
        //{
        //    get => base.Price * 1.3m;
        //}
    }
}
