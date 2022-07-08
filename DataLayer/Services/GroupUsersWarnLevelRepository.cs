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
    public class GroupUsersWarnLevelRepository : IGroupUsersWarnLevelRepository
    {
        JosefRoBotContext db;
        public GroupUsersWarnLevelRepository(JosefRoBotContext context)
        {
            db = context;
        }
        public IEnumerable<GroupUsersWarnLevel> SelectAllUsersWarns()
        {
            return db.groupUsersWarnLevels;
        }

        public GroupUsersWarnLevel SelectOneUserWarns(int userWarnsID)
        {
            return db.groupUsersWarnLevels.Find(userWarnsID);
        }
        public bool AddUserWarns(GroupUsersWarnLevel userWarn)
        {
            try
            {
                GroupUsersWarnLevel groupUsersWarnLevel = new GroupUsersWarnLevel()
                {
                    UserWarnLevelID = userWarn.UserWarnLevelID,
                    UserID = userWarn.UserID,
                    GroupID = userWarn.GroupID,
                    WarnLevel = 1
                };
                db.groupUsersWarnLevels.Add(groupUsersWarnLevel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public short ManageUserWarns(GroupUsersWarnLevel userWarn)
        {
            short result = 0; //0: error recived; 1: warn added ;2: user removed
            try
            {
                if (userWarn.WarnLevel != 0)
                {
                    if (userWarn.WarnLevel < userWarn.groups.MaxWarnLevel)
                    {
                        userWarn.WarnLevel++;
                        result = 1;//add warn
                    }
                    DeleteUserWarns(userWarn.UserWarnLevelID);
                    result = 2;//user removed
                }
            }
            catch (Exception)
            {
                result = 0; //error recived
            }
            return result;
        }
        public bool DeleteUserWarns(int userWarnsID)
        {
            try
            {
                db.Entry(SelectOneUserWarns(userWarnsID)).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUserWarns(GroupUsersWarnLevel userWarn)
        {
            try
            {
                db.Entry(userWarn).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}