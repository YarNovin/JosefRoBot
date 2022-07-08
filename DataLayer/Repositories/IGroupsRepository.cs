using System;
using System.Collections.Generic;
using DataLayer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IGroupsRepository : IDisposable
    {
        IEnumerable<Groups> SelectAllGroups();
        Groups SelectOneGroup(int groupID);
        bool AddGroup(Groups group);
        bool ChangeGroupInfo(Groups groups);
        bool DeleteGroup(int groupID);
        bool DeleteGroup(Groups group);
        void Save();
    }
}
