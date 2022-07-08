using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repositories
{
    public interface IUserLocalBioRepository:IDisposable
    {
        UsersLocalBio GetOneUserLocalBio(int userLocalBioID);
        bool AddUserLocalBio(UsersLocalBio userLocalBio);
        bool RemoveUserLocalBio(int userLocalBioID);
        bool RemoveUserLocalBio(UsersLocalBio usersLocalBio);
        void Save();
    }
}
