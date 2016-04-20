﻿using System;
using WebFormLogin.DataAccess.Models;
using WebFormLogin.UI2.Infrastructures;
using WebFormLogin.UI2.Services;

namespace WebFormLogin.UI2
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly IUserService userService = new UserService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var name = Name.Text.ToString();
            var subname = SurName.Text.ToString();
            var email = Email.Text.ToString();
            var phone = Phone.Text.ToString();
            var nickname = NickName.Text.ToString();
            var password = Password.Text.ToString();
            var confirmPassword = ConfirmPassword.Text.ToString();

            if (name.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input name";
            }
            if (subname.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input sub name";
            }
            if (nickname.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input nikc name";
            }
            if (password.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input password";
            }
            var user = new User();
            user.Name = name;
            user.SurName = subname;
            user.Email = email;
            user.Phone = phone;
            user.UserName = nickname;
            user.Password = password;
            var model = userService.AddUser(user);
            if (model.IsNull())
            {
                Notification.Text = "Please try again";
            }
            else
            {
                Response.Redirect("RegisterSuccess.aspx");
            }

        }
    }
}