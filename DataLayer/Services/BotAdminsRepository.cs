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
    public class BotAdminsRepository : IBotAdminsRepository
    {
        JosefRoBotContext db;
        public BotAdminsRepository(JosefRoBotContext context)
        {
            db = context;
        }
        public IEnumerable<BotAdmins> GetAllBotAdmins()
        {
            return db.botAdmins;
        }

        public BotAdmins GetOneBotAdmin(int botAdminID)
        {
            return db.botAdmins.Find(botAdminID);
        }
        public bool AddBotAdmin(BotAdmins botAdmin)
        {
            try
            {
                db.botAdmins.Add(botAdmin);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveBotAdmin(int botAdminID)
        {
            try
            {
                BotAdmins botAdmin = GetOneBotAdmin(botAdminID);
                db.Entry(botAdmin).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveBotAdmin(BotAdmins botAdmin)
        {
            try
            {
                db.Entry(botAdmin).State = EntityState.Deleted;
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
