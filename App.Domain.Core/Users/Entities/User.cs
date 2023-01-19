using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities.Users
{
    public abstract class User
    {
        private string passWord;
        public int id;
        public string userName;
        public bool isActived;
        protected User(int userId, string userName, string passWord)
        {
            this.id = userId;
            this.userName = userName;
            this.passWord = passWord;
            this.isActived = false;
        }
        public virtual bool Activate()
        {
            isActived = true;
            return true;
        }
        public bool Deactivate()
        {
            isActived = false;
            return true;
        }

        public bool ChangePassWord(string oldPassWord, string newPassWord)
        {
            if (passWord != oldPassWord)
                return false;

            passWord = newPassWord;
            return true;
        }
        public bool CheckPassWord(string passWord)
        {
            if (passWord == this.passWord)
                return true;
            else
                return false;

        }
    }
}
