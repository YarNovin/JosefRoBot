using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer.Services
{
    public class GroupUsersEthipets : IGroupUsersEpithetsRepository
    {
        JosefRoBotContext db;
        public GroupUsersEthipets(JosefRoBotContext context)
        {
            db = context;
        }
        public IEnumerable<GroupUsersEpithets> SelectAllUsersEpithets()
        {
            return db.groupUsersEpithets;
        }

        public GroupUsersEpithets SelectOneUserEpithet(int userEthipetID)
        {
            return db.groupUsersEpithets.Find(userEthipetID);
        }
        public bool AddUserEpithet(GroupUsersEpithets userEthipet)
        {
            try
            {
                db.groupUsersEpithets.Add(userEthipet);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ChangeUserEpithet(GroupUsersEpithets userEthipet)
        {
            try
            {
                db.Entry(userEthipet).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteUserEpithet(int userEthipetID)
        {
            try
            {
                GroupUsersEpithets groupUsersEpithets = SelectOneUserEpithet(userEthipetID);
                db.Entry(groupUsersEpithets).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUserEpithet(GroupUsersEpithets userEthipet)
        {
            try
            {
                db.Entry(userEthipet).State = EntityState.Deleted;
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