
namespace Server.Repository
{
    public static class Repository
    {
        private static readonly Lazy<Db> _instance = new Lazy<Db>(() => new Db());
        public static Db Context => _instance.Value;

        public static void SaveChanges()
        {
            Context.SaveChanges();
        }

        public static void Dispose()
        {
            Context.Dispose();
        }
    }
}
