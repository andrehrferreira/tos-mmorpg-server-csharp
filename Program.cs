using Server;
using DotNetEnv;

public class Program
{
    public static async Task Main(string[] args)
    {
        Env.TraversePath().Load(); //Services Settings
        _ = Queue.ExecuteAsync();

        GameServerSettings.Load("game-server.yml"); //Game Server Settings
        Repository.Initialize(); //Connect to Database

        //Load Base
        Items.Init();

        //await Repository.MapsLoadAll();
        await Repository.ItemsLoadAll();
        await Repository.ContainersLoadAll();
        await Repository.GuildsLoadAll();
        await Repository.CharactersLoadAll();

        WebSocketServer server = new WebSocketServer();
        await server.StartAsync();
    }
}