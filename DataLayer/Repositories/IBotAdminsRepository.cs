using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IBotAdminsRepository:IDisposable
    {
        IEnumerable<BotAdmins> GetAllBotAdmins();
        BotAdmins GetOneBotAdmin(int botAdminID);
        bool AddBotAdmin(BotAdmins botAdmin);
        bool RemoveBotAdmin(BotAdmins botAdmin);
        bool RemoveBotAdmin(int botAdminID);
        void Save();
    }
}
