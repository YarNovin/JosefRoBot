using System;
using System.Collections.Generic;
using DataLayer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IGroupUsersWarnLevelRepository : IDisposable
    {
        IEnumerable<GroupUsersWarnLevel> SelectAllUsersWarns();
        GroupUsersWarnLevel SelectOneUserWarns(int userWarnsID);
        bool AddUserWarns(GroupUsersWarnLevel userWarn);
        short ManageUserWarns(GroupUsersWarnLevel userWarn);
        bool DeleteUserWarns(int userWarnsID);
        bool DeleteUserWarns(GroupUsersWarnLevel userWarn);
        void Save();
    }
}
