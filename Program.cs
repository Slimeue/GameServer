namespace server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Server";
            Server.Start(10, 26950);
            GameLogic gameLogic = new GameLogic();
            await gameLogic.GameLoopAsync(); // properly awaited
        }
    }
}
