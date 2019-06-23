using Auth.Contracts;
using Auth.Contracts.Models;
using System;
using System.Collections.Generic;

namespace Auth.Manager
{
    public class AuthManager: IAuthManager
    {
        AuthManager() {

        }

        public IEnumerable<loginType> GetLoginTypes(bool? isActive)
        {
            return IAuthDataAccess
        }
}
