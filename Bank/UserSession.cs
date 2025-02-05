namespace Bank
{
    public static class UserSession
    {
        public static string Username { get; private set; }
        public static string Role { get; private set; }
        public static string Password { get; private set; } // Новый параметр для пароля

        public static void SetUser(string username, string role, string password)
        {
            Username = username;
            Role = role;
            Password = password;  // Устанавливаем пароль
        }

        public static void Clear()
        {
            Username = null;
            Role = null;
            Password = null;  // Очищаем пароль
        }
    }
}
