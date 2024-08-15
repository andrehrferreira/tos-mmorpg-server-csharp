
namespace Server
{
    public static partial class Repository
    {
        public static async Task MapsLoadAll()
        {
            Console.WriteLine("Loading Maps Data...");

            var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "maps");
            var dataFiles = Directory.GetFiles(dataPath, "*.data");

            foreach (var pathFile in dataFiles)
            {
                var levelName = Path.GetFileNameWithoutExtension(pathFile);
                var data = await File.ReadAllTextAsync(pathFile);
                var totalSpots = Maps.ParseLevelData(levelName, data);

                Console.WriteLine($"Map {levelName} loaded {totalSpots} spots...");
            }

            Console.WriteLine("Map loading completed");
        }
    }
}
