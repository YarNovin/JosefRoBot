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
    public class GroupsRepository : IGroupsRepository
    {
        JosefRoBotContext db;

        public GroupsRepository(JosefRoBotContext context)
        {
            db = context;
        }
        public IEnumerable<Groups> SelectAllGroups()
        {
            return db.groups;
        }

        public Groups SelectOneGroup(int groupID)
        {
            return db.groups.Find(groupID);
        }

        public bool AddGroup(Groups group)
        {
            try
            {
                db.groups.Add(group);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangeGroupInfo(Groups groups)
        {
            try
            {
                db.Entry(groups).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteGroup(int groupID)
        {
            Groups group = SelectOneGroup(groupID);
            db.Entry(group).State = EntityState.Deleted;
            return true;
        }

        public bool DeleteGroup(Groups group)
        {
            return false;
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
