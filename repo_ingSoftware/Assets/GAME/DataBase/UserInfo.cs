using Boo.Lang;
using System;
using System.Globalization;

namespace DataBase
{
    [Serializable]
    public class UserInfo
    {
        // basic info
        private string name;
        private string password;
        private string mail;

        // config info
        private bool isMute;
        private Lenguage lenguage;

        // game info
        private List<string> pieces = new List<string>();
        private List<string> tropies = new List<string>();

        public UserInfo(string name, string password, string mail)
        {
            this.name = name;
            this.password = password;
            this.mail = mail;

            isMute = false;
            lenguage = Lenguage.Spanish;

            pieces = new List<string>();
            tropies = new List<string>();
        }

        public bool AddPiece(string name)
        {
            if(!pieces.Contains(name))
            {
                pieces.Add(name);
                return true;
            }

            return false;
        }

        public bool havePiece(string name)
        {
            return pieces.Contains(name);
        }

        public bool AddTropy(string name)
        {
            if (!pieces.Contains(name))
            {
                tropies.Add(name);
                return true;
            }

            return false;
        }

        public bool haveTropy(string name)
        {
            return tropies.Contains(name);
        }


        public override bool Equals(object obj)
        {
            var other = (UserInfo)obj;
            if (other != null)
            {
                return this.name.Equals(other.name);
            }

            var name = (string)obj;
            if(name != null)
            {
                return this.name.Equals(name);
            }

            return false;
        }
    }
}