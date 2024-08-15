using Server;
using DotNetEnv;

public class Program
{
    public static async Task Main(string[] args)
    {
        Env.Load();
        _ = Queue.ExecuteAsync();

        //Load Base
        Items.Init();

        //await Repository.MapsLoadAll();
        await Repository.ItemsLoadAll();

        WebSocketServer server = new WebSocketServer();
        await server.StartAsync();
    }
}