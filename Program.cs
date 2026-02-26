namespace server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";

            Server.Start(10, 26950);

            Console.ReadKey();
        }
    }
}
