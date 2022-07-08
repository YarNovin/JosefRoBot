using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
#nullable disable

    public class GroupUsersWarnLevel
    {
        [Key]
        public int UserWarnLevelID { get; set; }
        [Required]
        public int GroupID { get; set; }
        [Required]
        public long UserID { get; set; }
        [Required]
        public int WarnLevel { get; set; } //user warn level
        //relations
        public virtual Groups groups { get; set; }
        public GroupUsersWarnLevel()
        {

        }
    }
}
