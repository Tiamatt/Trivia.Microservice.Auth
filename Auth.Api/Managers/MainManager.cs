using System.Linq;
using System.Collections.Generic;
using Auth.Contracts;
using Auth.Contracts.Managers;
using Auth.Contracts.ApiModels;

namespace Auth.Api.Managers
{
    public class MainManager: IMainManager
    {
        private readonly IMainDataAccess _mainDataAccess;

        public MainManager(IMainDataAccess mainDataAccess)
        {
            _mainDataAccess = mainDataAccess;
        }

        public GetLoginTypesResponse GetLoginTypes(bool? isActive)
        {
            var loginTypes = _mainDataAccess.GetLoginTypes(isActive);
            var results = new GetLoginTypesResponse() {
                loginTypes = loginTypes
            };
            return results;
        }
    }
}
