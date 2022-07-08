using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
#nullable disable

    public class Groups
    {
        [Key]
        public int GroupID { get; set; }
        [Required]
        public bool IsGroupEnglish { get; set; }
        [Required]
        public int MaxWarnLevel { get; set; } // max level of warn then bot kick user automaticaly

        //relations
        public virtual List<GroupAdmins> groupAdmins { get; set; }
        public virtual List<GroupUsersEpithets> groupUsersEpithets { get; set; }
        public virtual List<GroupUsersWarnLevel> groupUsersWarnLevel { get; set; }
        public Groups()
        {

        }
    }
}
