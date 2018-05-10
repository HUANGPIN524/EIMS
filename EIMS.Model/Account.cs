using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public bool IsAdmin { get; set; }
        public Account() { }
        public Account(string AccountName, string AccountPassword, bool IsAdmin)
        {
            this.AccountName = AccountName;
            this.AccountPassword = AccountPassword;
            this.IsAdmin = IsAdmin;
        }
        public Account(int AccountId,string AccountName, string AccountPassword, bool IsAdmin)
        {
            this.AccountId = AccountId;
            this.AccountName = AccountName;
            this.AccountPassword = AccountPassword;
            this.IsAdmin = IsAdmin;
        }
    }
}
