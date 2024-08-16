namespace Server
{
    public static partial class Repository
    {
        public static async Task MapsLoadAll()
        {
            Logger.Log("Loading Maps Data...");

            var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "maps");
            var dataFiles = Directory.GetFiles(dataPath, "*.data");

            foreach (var pathFile in dataFiles)
            {
                var levelName = Path.GetFileNameWithoutExtension(pathFile);
                var data = await File.ReadAllTextAsync(pathFile);
                var totalSpots = Maps.ParseLevelData(levelName, data);

                Logger.Log($"Map {levelName} loaded {totalSpots} spots...");
            }

            Logger.Log("Map loading completed");
        }
    }
}
