using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;

namespace WebFormLogin.DataAccess
{
    public partial class WebFormLoginContext : DbContext
    {
        public WebFormLoginContext()
            : base("Name=WebFormLoginContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
