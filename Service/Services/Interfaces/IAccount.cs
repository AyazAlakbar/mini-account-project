using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IAccount
    {
        string Login(string email, string password, int role);
    }
}
