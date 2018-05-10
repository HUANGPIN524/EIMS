using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSex { get; set; }
        public string UserNumberId { get; set; }
        public string UserPhone { get; set; }
        public string UserIcon { get; set; }
        public int AccountId { get; set; }
        public User() { }
        public User(string UserName, string UserSex, string UserNumberId, string UserPhone ,string UserIcon, int AccountId)
        {
            this.UserName = UserName;
            this.UserSex = UserSex;
            this.UserNumberId = UserNumberId;
            this.UserPhone = UserPhone;
            this.UserIcon = UserIcon;
            this.AccountId = AccountId;
        }
        public User(int UserId,string UserName, string UserSex, string UserNumberId, string UserPhone, string UserIcon, int AccountId)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserSex = UserSex;
            this.UserNumberId = UserNumberId;
            this.UserPhone = UserPhone;
            this.UserIcon = UserIcon;
            this.AccountId = AccountId;
        }
    }
}
