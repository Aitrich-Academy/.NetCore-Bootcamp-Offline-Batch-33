namespace encapsulation1
{
    internal class Program
    {
        class User
        {
            private string _password;

            public void setpassword(string password)
            {
                _password = password;
            }
            public void login(string enternedpassword)
            {
                if (enternedpassword == _password)
                {
                    Console.WriteLine("login successfully");

                }
                else
                {
                    Console.WriteLine("incorrect password");
                }

            }


            static void Main(string[] args)
            {
                User user = new User();
                user.setpassword("set123");
                user.login("wrongpass");
                user.login("set123");
            }
        }
    }
}
