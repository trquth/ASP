using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.DataAccess.Models
{
    [Table("Table")]
    public class Table : BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
