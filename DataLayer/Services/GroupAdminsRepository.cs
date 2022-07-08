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
    public class GroupAdminsRepository : IGroupAdminsRepository
    {
        JosefRoBotContext db;
        public GroupAdminsRepository(JosefRoBotContext context)
        {
            db = context;
        }
        public IEnumerable<GroupAdmins> SelectAllAdmins()
        {
            return db.groupAdmins;
        }

        public GroupAdmins SelectOneAdmin(int groupAdminID)
        {
            return db.groupAdmins.Find(groupAdminID);
        }
        public bool AddGroupAdmin(GroupAdmins groupAdmin)
        {
            try
            {
                db.groupAdmins.Add(groupAdmin);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditAdminInformation(GroupAdmins groupAdmin)
        {
            try
            {
                db.Entry(groupAdmin).State =EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAdmin(int groupAdminID)
        {
            try
            {
                GroupAdmins groupAdmin = SelectOneAdmin(groupAdminID);
                db.Entry(groupAdmin).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAdmin(GroupAdmins groupAdmin)
        {
            try
            {
                db.Entry(groupAdmin).State = EntityState.Deleted;
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
