using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Interfaces
{
   public interface IUserService
    {
        bool AuthenticateUser(string username, string password);
    }
}
