using Server;

public class Program
{
    public static async Task Main(string[] args)
    {
        //await CharacterService.
        await MapsService.LoadAll();

        //WebSocketServer server = new WebSocketServer();
        //await server.StartAsync();
    }
}