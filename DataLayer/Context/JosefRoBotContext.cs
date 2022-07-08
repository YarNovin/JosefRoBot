using System;
using System.Collections.Generic;
//using System.Data.Entity;
using DataLayer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
#nullable disable
    public class JosefRoBotContext : DbContext
    {
        public DbSet<Groups> groups { get; set; }
        public DbSet<GroupAdmins> groupAdmins { get; set; }
        public DbSet<GroupUsersEpithets> groupUsersEpithets { get; set; }
        public DbSet<GroupUsersWarnLevel> groupUsersWarnLevels { get; set; }
        public DbSet<UsersLocalBio> usersLocalBio { get; set; }
        public DbSet<BotAdmins> botAdmins { get; set; }

        public JosefRoBotContext(DbContextOptions<JosefRoBotContext> options) : base(options)
        {

        }
        //protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        //{

        //}
    }
}