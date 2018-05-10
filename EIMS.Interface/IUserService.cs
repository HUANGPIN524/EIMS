using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EIMS.Model;
namespace EIMS.Interface
{
    public interface IUserService
    {
        bool Register(Account account);
        bool Login(Account account);
        bool ChangePassword(string OldPass,string NewPass);
        bool FillUserInfo(User user);
    }
}
