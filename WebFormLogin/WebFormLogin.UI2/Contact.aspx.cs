using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormLogin.UI2.Infrastructures;
using WebFormLogin.UI2.Services;

namespace WebFormLogin.UI2
{
    public partial class Contact : System.Web.UI.Page
    {
        private readonly IContactService contactService = new ContactService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                WelcomeBackMessage.Text = "Welcome !";

                AuthenticatedMessagePanel.Visible = true;
                AnonymousMessagePanel.Visible = false;
                Response.Redirect("Login.aspx");
            }
            else
            {
                AuthenticatedMessagePanel.Visible = false;
                AnonymousMessagePanel.Visible = true;
                
            }
        }
        protected void btnSent_Click(object sender, EventArgs e)
        {
            var name = FullName.Text.ToString();
            var address = Address.Text.ToString();
            var email = Email.Text.ToString();
            var phone = Phone.Text.ToString();
            var opinion = Opinion.Text.ToString();

            if (name.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input full name";
            }
            else if (address.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input address";
            }
            else if (email.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input email";
            }
            else if (phone.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input phone";
            }
            else if (opinion.StringIsNullEmptyWhiteSpace())
            {
                Notification.Text = "Please input opinion";
            }
            else
            {
                var contact = new WebFormLogin.DataAccess.Models.Contact();
                contact.FullName = name;
                contact.Address = address;
                contact.Email = email;
                contact.Phone = phone;
                contact.Opinion = opinion;
                var model = contactService.AddContact(contact);
                if (model.IsNull())
                {
                    Notification.Text = "Please try again";
                }
                else
                {
                    NotificationSuccess.Text = "Sent success";
                    ClearFields(Form.Controls);
                }
            }
        }
        public static void ClearFields(ControlCollection pageControls)
        {
            foreach (Control contl in pageControls)
            {
                string strCntName = (contl.GetType()).Name;

                switch (strCntName)
                {
                    case "TextBox":
                        TextBox tbSource = (TextBox)contl;
                        tbSource.Text = "";
                        break;
                    case "RadioButtonList":
                        RadioButtonList rblSource = (RadioButtonList)contl;
                        rblSource.SelectedIndex = -1;
                        break;
                    case "DropDownList":
                        DropDownList ddlSource = (DropDownList)contl;
                        ddlSource.SelectedIndex = -1;
                        break;
                    case "ListBox":
                        ListBox lbsource = (ListBox)contl;
                        lbsource.SelectedIndex = -1;
                        break;
                }
                ClearFields(contl.Controls);
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }
    }
}