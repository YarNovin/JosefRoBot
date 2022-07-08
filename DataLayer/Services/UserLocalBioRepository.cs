using System;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;

namespace DataLayer.Services
{
    public class UserLocalBioRepository : IUserLocalBioRepository
    {
        JosefRoBotContext db;
        public UserLocalBioRepository(JosefRoBotContext context)
        {
            db = context;
        }
        public UsersLocalBio GetOneUserLocalBio(int userLocalBioID)
        {
            return db.usersLocalBio.Find(userLocalBioID)!;
        }
        public bool AddUserLocalBio(UsersLocalBio userLocalBio)
        {
            try
            {
                UsersLocalBio specificUserLocalBio;
                if (db.usersLocalBio.Find(userLocalBio.UserLocalBioID)!=null)
                {
                    specificUserLocalBio = db.usersLocalBio.Find(userLocalBio.UserLocalBioID)!;
                    db.Entry(specificUserLocalBio).State = EntityState.Deleted;
                    db.usersLocalBio.Add(userLocalBio);
                }
                else
                {
                    db.usersLocalBio.Add(userLocalBio);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveUserLocalBio(int userLocalBioID)
        {
            try
            {
                db.Entry(GetOneUserLocalBio(userLocalBioID)).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveUserLocalBio(UsersLocalBio usersLocalBio)
        {
            try
            {
                db.Entry(usersLocalBio).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}