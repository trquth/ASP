using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.DataAccess.Models
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            Created = DateTime.Now;
            IsDeleted = false;
        }
    }
}
