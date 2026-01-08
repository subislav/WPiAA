using System;

namespace SingletonVault
{
    public class Vault
    {
        private static Vault _instance;
        private string _accessKey = "KLUCZ-CYFROWY-123";
        public static Vault GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Vault();
            }
            return _instance;
        }
        public string GetAccessKey()
        {
            if (_accessKey != null)
            {
                string keyToGive = _accessKey;
                _accessKey = null;
                return keyToGive;
            }
            else
            {
                return "Klucz zużyty";
            }
        }
    }
}