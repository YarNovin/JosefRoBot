using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
#nullable disable

    public class GroupUsersEpithets //Nicknames for group users for what robot call them
    {
        [Key]
        public int UserEpithetsID { get; set; }
        [Required]
        public int GroupID { get; set; }
        [Required]
        public long UserID { get; set; }
        [Required]
        [MaxLength(60)]
        public string Epithet { get; set; }
        //relations
        public virtual Groups groups { get; set; }
        public GroupUsersEpithets()
        {

        }
    }
}
