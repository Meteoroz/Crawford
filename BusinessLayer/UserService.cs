using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class UserService : IUserService
    {
        public bool Login(string userName, string password)
        {
            return true;
        }
    }
}
