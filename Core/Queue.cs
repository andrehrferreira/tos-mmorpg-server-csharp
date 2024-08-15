using System.Text.Json;
using StackExchange.Redis;

namespace Server
{
    public class JobData
    {
        public string Table { get; set; }
        public string Id { get; set; }
        public object Set { get; set; }
        public string Token { get; set; }
        public string ContainerId { get; set; }
        public string CharacterId { get; set; }
    }

    public static class Queue
    {
        private static readonly ConnectionMultiplexer Redis;
        private static readonly IDatabase Db;
        private static CancellationTokenSource CancelToken;

        static Queue()
        {
            Redis = ConnectionMultiplexer.Connect("localhost,abortConnect=false");
            Db = Redis.GetDatabase();
        }

        public static async Task EnqueueUpdateJobAsync(JobData job)
        {
            string jobJson = JsonSerializer.Serialize(job);
            await Db.ListRightPushAsync("gameserver:update", jobJson);
        }

        public static async Task EnqueueDeleteJobAsync(JobData job)
        {
            string jobJson = JsonSerializer.Serialize(job);
            await Db.ListRightPushAsync("gameserver:delete", jobJson);
        }

        public static async Task ExecuteAsync()
        {
            CancelToken = new CancellationTokenSource();

            while (!CancelToken.IsCancellationRequested)
            {
                var updateJob = await Db.ListLeftPopAsync("gameserver:update");
                var deleteJob = await Db.ListLeftPopAsync("gameserver:delete");

                if (!string.IsNullOrEmpty(updateJob))                
                    await ProcessUpdateJobAsync(updateJob);                

                if (!string.IsNullOrEmpty(deleteJob))                
                    await ProcessDeleteJobAsync(deleteJob);
                
                await Task.Delay(1000, CancelToken.Token);
            }
        }

        public static void Stop()
        {
            CancelToken.Cancel();
        }

        private static async Task ProcessUpdateJobAsync(string jobJson)
        {
            var job = JsonSerializer.Deserialize<JobData>(jobJson);

            switch (job.Table)
            {
                case "character":await Repository.UpdateCharacter(job.Id, job.Set as CharacterEntity); break;
                case "item": await Repository.UpdateItem(job.Id, job.Set as ItemEntity); break;
                case "container": await Repository.UpsertContainer(job.Set as ContainerEntity); break;
            }
        }

        private static async Task ProcessDeleteJobAsync(string jobJson)
        {
            var job = JsonSerializer.Deserialize<JobData>(jobJson);

            switch (job.Table)
            {
                case "character": await Repository.DeleteCharacter(job.Id); break;
                case "item": await Repository.DeleteItem(job.Id); break;
                case "container": await Repository.DeleteContainer(job.ContainerId); break;
            }
        }
    }
}
