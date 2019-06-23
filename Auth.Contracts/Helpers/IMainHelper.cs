using Auth.Contracts.ApiModels;

namespace Auth.Contracts.Helpers
{
    public interface IMainHelper
    {
        GetLoginTypesResponse GetLoginTypes(bool? isActive);
    }
}
