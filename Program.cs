using Server;

public class Program
{
    public static async Task Main(string[] args)
    {
        WebSocketServer server = new WebSocketServer();
        await server.StartAsync();
    }
}