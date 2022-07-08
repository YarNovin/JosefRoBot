using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
#nullable disable
    public class BotAdmins
    {
        [Key]
        public int AdminID { get; set; }
        [Required]
        public string AdminPassword { get; set; }
        [Required]
        public long AdminTelegramNumbericID { get; set; }

        public BotAdmins()
        {

        }
    }
}
