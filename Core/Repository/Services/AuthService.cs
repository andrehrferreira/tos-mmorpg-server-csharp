using DotNetEnv;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using MongoDB.Driver;
using Server.Handlers;

namespace Server
{
    public static partial class Repository
    {
        public async static Task<LoginResult> Login(LoginMessage data, Plevel minPlevel = Plevel.CommunityManager)
        {
            try
            {
                if (data.Username == "" || data.Password == "")
                    throw new Exception("Username or password is invalid.");

                var hashedUsername = Crypto.HashUsername(data.Username);
                var hashedPassword = Crypto.HashPassword(data.Password);

                var userInfo = await AuthenticateCollection.Find(pm => pm.username == hashedUsername && pm.password == hashedPassword)
                    .FirstOrDefaultAsync();

                if (userInfo == null)
                {
                    var hasUser = await AuthenticateCollection.Find(pm => pm.username == hashedUsername)
                        .FirstOrDefaultAsync();

                    if (hasUser != null)
                    {
                        var refId = data.Username.Replace("@", "").Substring(0, 6);
                        var emailToken = Crypto.EncryptEmail(data.Username);

                        await AuthenticateCollection.InsertOneAsync(new AuthenticateModel
                        {
                            hashtag = $"{refId.Substring(0, 10).ToUpper()}#{CreateHash()}",
                            username = hashedUsername,
                            password = hashedPassword,
                            emailToken = emailToken,
                            emailValidation = true,
                            plevel = Plevel.Player,
                            othersId = []
                        });

                        userInfo = await AuthenticateCollection.Find<AuthenticateModel>(pm => pm.username == hashedUsername && pm.password == hashedPassword)
                            .FirstOrDefaultAsync();
                    }
                }

                if (userInfo == null)
                    throw new UnauthorizedAccessException("It was not possible to log in because your username was not found or the password was invalid.");

                if (userInfo.banned)
                    throw new UnauthorizedAccessException("Your account is banned. If you have any questions or wish to dispute the ban, please contact support on our website https://talesofshadowland.com");

                if (userInfo.block)
                {
                    if (userInfo.blockTimeout > DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())
                        throw new UnauthorizedAccessException($"Your account is blocked until this date: {DateTimeOffset.FromUnixTimeMilliseconds(userInfo.blockTimeout).ToString("yyyy-MM-ddTHH:mm:ssZ")}");
                    //else 
                    //  await Repository.RemoveBlockAccount(userInfo._id);
                }

                if (userInfo.plevel < minPlevel)
                {
                    throw new UnauthorizedAccessException($"Your user does not have permission to access this area.");
                }
                else
                {
                    //Email validation

                    //Validate 2factor if was a administrator plevel

                    //Validate fingerprint authorization session
                }

                var update = Builders<AuthenticateModel>.Update.Set("lastLogin", DateTime.UtcNow);
                await AuthenticateCollection.UpdateOneAsync(a => a.Id == userInfo.Id, update);

                var payload = new
                {
                    exp = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60 * 60 * 24),
                    data = new
                    {
                        masterId = userInfo.Id.ToString(),
                        applicant = data.Applicant,
                        plevel = userInfo.plevel,
                    }
                };

                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); 
                IJsonSerializer serializer = new JsonNetSerializer(); 
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                var token = encoder.Encode(payload, Env.GetString("TOS_JWT_SECRET"));

                return new LoginResult { token = token, plevel = userInfo.plevel, id = userInfo.Id.ToString() };
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
                return new LoginResult { token = null, plevel = Plevel.Player, id = null };
            }
        }

        private static int CreateHash()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }
    }
}
