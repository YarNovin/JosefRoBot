using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    /// <summary>
    /// Local BioGraphy of users in Telegram.
    /// users set this in Bot PV and whene others want his Bio bot gives them this
    /// </summary>
#nullable disable
    /// 
    public class UsersLocalBio
    {
        [Key]
        public int UserLocalBioID { get; set; }
        [Required]
        public long UserTelegramID { get; set; }
        [Required]
        public string Biography { get; set; }
        public DateTime SubmitDate { get; set; }

        public UsersLocalBio()
        {

        }
    }
}