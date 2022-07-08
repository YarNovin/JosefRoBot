using System;
using System.Collections.Generic;
using DataLayer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IGroupAdminsRepository : IDisposable
    {
        IEnumerable<GroupAdmins> SelectAllAdmins(); //to show all group's admins
        GroupAdmins SelectOneAdmin(int groupAdminID);
        bool AddGroupAdmin(GroupAdmins groupAdmin);
        bool EditAdminInformation(GroupAdmins groupAdmin);
        bool DeleteAdmin(int groupAdminID);
        bool DeleteAdmin(GroupAdmins groupAdmin);
        void Save();
    }
}
