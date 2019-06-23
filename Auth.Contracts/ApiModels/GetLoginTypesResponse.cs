using Entities = Auth.Contracts.Entities;
using System.Collections.Generic;

namespace Auth.Contracts.ApiModels
{
    public class GetLoginTypesResponse
    {
        public IEnumerable<Entities.loginType> loginTypes { get; set; }
    }
}
