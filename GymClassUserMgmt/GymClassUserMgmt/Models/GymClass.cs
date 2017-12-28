using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymClassUserMgmt.Models
{
    public class GymClass
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        //[RegularExpression(@"^(0[1-9]|1[0-2]):[0-5][0-9] (am|pm|AM|PM)$", ErrorMessage = "Invalid Time.")]
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Column(TypeName = "datetime2")]
        [DisplayName("End Time")]
        public DateTime EndTime { get { return StartTime + Duration; } }

        [Required]
        public string Description { get; set; }



        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
    }
}