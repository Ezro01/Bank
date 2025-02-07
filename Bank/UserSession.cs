namespace Bank
{
    public static class UserSession
    {
        public static string Username { get; private set; }
        public static string Role { get; private set; }
        public static string Password { get; private set; }

        public static string Server { get; private set; }

        public static void SetUser(string username, string role, string password, string server)
        {
            Username = username;
            Role = role;
            Password = password;  
            Server = server;
        }

        public static void Clear()
        {
            Username = null;
            Role = null;
            Password = null;
            Server = null;
        }
    }
}
