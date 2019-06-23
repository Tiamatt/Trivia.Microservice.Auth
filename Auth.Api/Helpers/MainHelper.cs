using System.Linq;
using System.Collections.Generic;
using Auth.Contracts;
using Auth.Contracts.Helpers;
using Auth.Contracts.ApiModels;

namespace Auth.Api.Helpers
{
    public class MainHelper: IMainHelper
    {
        private readonly IMainDataAccess _mainDataAccess;

        public MainHelper(IMainDataAccess mainDataAccess)
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
