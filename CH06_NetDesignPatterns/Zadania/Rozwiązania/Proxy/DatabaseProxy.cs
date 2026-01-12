using System;

namespace Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private IDatabase _realDatabase;
        private string _password;
        public DatabaseProxy(string password)
        {
            _password = password;
        }
        public void DisplayData()
        {
            if (_password == "haslo123")
            {
                Console.WriteLine("Hasło poprawne - przyznano dostęp do danych zastrzeżonych.");
                _realDatabase = new SecretDatabase();
                _realDatabase.DisplayData();
            }
            else
            {
                Console.WriteLine("Błędne hasło - przekierowano do danych ogólnodostępnych.");
                _realDatabase = new PublicDatabase();
                _realDatabase.DisplayData();
            }
        }
    }
}