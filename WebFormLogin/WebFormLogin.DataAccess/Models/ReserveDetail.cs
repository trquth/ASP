using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.DataAccess.Models
{
    public enum DayEnum
    {
        [Description("Morning")]
        Morning = 0,
        [Description("Afternoon")]
        Afternoon = 1,
        [Description("Everning")]
        Everning = 2,
    }
    [Table("ReserveDetail")]
    public class ReserveDetail : BaseEntity
    {
        public Guid TableId { get; set; }
        public Guid UserId { get; set; }
        public DayEnum Day { get; set; }
    }
}
