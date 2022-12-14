namespace Portfolio
{
    class JopBertrams : IPortfolio
    {
        public string Name { get { return "Jop Bertrams"; } }
        public int Age { get { return 20; } }
        public string Location { get { return "Netherlands"; } }

        static void Main(string[] args)
        {
            System.Console.WriteLine(portfolio.Name);
            System.Console.WriteLine(portfolio.Age);
            System.Console.WriteLine(portfolio.Location);
        }
    }
}