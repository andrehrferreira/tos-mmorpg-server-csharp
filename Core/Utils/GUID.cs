
namespace Server
{
    class GUID 
    {
        public static string Generate()
        {
            string S4()
            {
                return ((int)((1 + new Random().NextDouble()) * 0x10000)).ToString("x4").Substring(1);
            }

            return $"{S4()}{S4()}-{S4()}-{S4()}-{S4()}-{S4()}{S4()}{S4()}";
        }

        public static string NewID(int size = 6)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = string.Empty;
            var charactersLength = characters.Length;
            var random = new Random();

            for (int i = 0; i < size; i++)            
                result += characters[random.Next(charactersLength)];
          
            return result;
        }

        public static int ToInt(string Id)
        {
            return Convert.ToInt32(Id, 36);
        }

        public static string IntToId(int value)
        {
            return value.ToString("x").ToUpper();
        }
    }
}
