using Auth.Contracts.Entities;
using System.Collections.Generic;

namespace Auth.Contracts
{
    public interface IMainDataAccess
    {
        IEnumerable<loginType> GetLoginTypes(bool? isActive);
    }
}
