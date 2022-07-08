using System;
using System.Collections.Generic;
using DataLayer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IGroupUsersEpithetsRepository : IDisposable
    {
        IEnumerable<GroupUsersEpithets> SelectAllUsersEpithets();
        GroupUsersEpithets SelectOneUserEpithet(int userEthipetID);
        bool AddUserEpithet(GroupUsersEpithets userEthipet);
        bool ChangeUserEpithet(GroupUsersEpithets userEthipet);
        bool DeleteUserEpithet(int userEthipetID);
        bool DeleteUserEpithet(GroupUsersEpithets userEthipet);
        void Save();
    }
}
