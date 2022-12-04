using Service.Enums;
using Service.Helper.Constants;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int role)
        {
            if (email== Account_constants.Email && password==Account_constants.Password )
            {
                if (CheckRole(role))
                {
                    return Account_constants.SuperAdminSuccessfullEnterMessage;

                }
                else
                {
                    return Account_constants.SuperAdminUnsuccessfullEnterMessage;
                }

            }
            else
            {
                return Account_constants.WrongEmailOrPasswor;
            }
        }


        private bool CheckRole(int role)
        {
            return role == (int)Roles.SuperAdmin;
        }
    }
}
