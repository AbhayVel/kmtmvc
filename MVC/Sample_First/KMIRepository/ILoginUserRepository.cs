using CheckDatabaseFromEF;
using KmiEntities;

namespace KMIRepository
{
    public interface ILoginUserRepository
    {
        WorkdayContext WorkdayContext { get; set; }

        LoginUser GetLoginUser(string userName);
    }
}