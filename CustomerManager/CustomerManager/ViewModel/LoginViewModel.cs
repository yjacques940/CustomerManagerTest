using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManager.Repositories;

namespace CustomerManager.ViewModel
{
    public class LoginViewModel
    {
        private UserRepository repository;

        public LoginViewModel()
        {
                repository = new UserRepository();
        }
        internal bool Connect(string username, string password)
        {
            var userInfo = repository.GetUserInfo(username, password);
            if (userInfo != null)
            {
                Global.CurrentUserId = userInfo.Id;
                Global.CurrentUserName = userInfo.Name;
                Global.CurrentUserLastName = userInfo.LastName;
                return true;
            }
            return false;
        }
    }
}
