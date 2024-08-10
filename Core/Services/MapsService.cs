
namespace Server
{
    public static class MapsService
    {
        public static async Task<List<RespawnEntity>> GetRespawns(string map)
        {
            return await Repository.GetRespawnsAsync(map);
        }

        public static async Task<bool> CreateRespawn(RespawnEntity data)
        {
            return await Repository.CreateRespawnAsync(data);
        }

        public static async Task<bool> RemoveRespawn(string id)
        {
            return await Repository.RemoveRespawnAsync(id);
        }

        public static async Task LoadAll()
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
