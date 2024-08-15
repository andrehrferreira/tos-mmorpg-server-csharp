using Server;

public class Program
{
    public static async Task Main(string[] args)
    {
        //Load Base
        Items.Init();

        //await Repository.MapsLoadAll();
        await Repository.ItemsLoadAll();

        WebSocketServer server = new WebSocketServer();
        await server.StartAsync();
    }
}