namespace Server
{
    public static partial class Repository
    {
        private static readonly Lazy<Db> _instance = new Lazy<Db>(() => new Db());
        public static Db Context => _instance.Value;
    }
}
