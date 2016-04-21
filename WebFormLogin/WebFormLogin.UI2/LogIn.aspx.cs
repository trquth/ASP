using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormLogin.UI2.Infrastructures;
using WebFormLogin.UI2.Services;

namespace WebFormLogin.UI2
{
    public partial class LogIn : System.Web.UI.Page
    {
        private readonly IUserService userService = new UserService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = UserName.Text.ToString();
            var password = Password.Text.ToString();
            if (userName.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input name";
            }
            else if (password.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input password";
            }
            else if(userService.CheckUserNameAndPassword(userName,password.HashPassword()))
            {
                Response.Redirect("/Contact.aspx");               
            }
            else
            {
                Notification.Text = "User name/ Password is incorrect";
            }
            
        }
    }
}