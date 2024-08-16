namespace Server
{
    public struct LoginDTO
    {
        public string email;
        public string username;
        public string password;
        public string accountId;
        public string agent;
        public string fingerprint;
        public string token;
        public string code;
        public string applicant;
    }

    public struct LoginResult
    {
        public string token;
        public string id;
        public Plevel plevel;
    }
}
