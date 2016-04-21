using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormLogin.UI2.Services;

namespace WebFormLogin.UI2
{
    public partial class TableList : System.Web.UI.Page
    {
        private readonly ITableService tableService = new TableService(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = tableService.GetAll().OrderBy(x=>x.Order);
            ListData.DataSource = model;
            ListData.DataBind();
        }
        
    }
}