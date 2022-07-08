using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
#nullable disable
    public class GroupAdmins
    {
        [Key]
        public int GroupAdminID { get; set; }
        [Required]
        public int GroupID { get; set; }
        [Required]
        public long AdminID { get; set; } //numberic id of telegram user
        [Required]
        public int AdminAccessLevel { get; set; } //only 1-2-3-4 allowed
        //relations
        public virtual Groups groups { get; set; }
        public GroupAdmins()
        {

        }
    }
}
