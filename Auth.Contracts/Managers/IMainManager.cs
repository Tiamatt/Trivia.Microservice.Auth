using Auth.Contracts.ApiModels;

namespace Auth.Contracts.Managers
{
    public interface IMainManager
    {
        GetLoginTypesResponse GetLoginTypes(bool? isActive);
    }
}
