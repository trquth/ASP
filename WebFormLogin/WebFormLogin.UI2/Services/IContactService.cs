﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.UI2.Services
{
    public interface IContactService
    {
        WebFormLogin.DataAccess.Models.Contact AddContact(WebFormLogin.DataAccess.Models.Contact contact);
    }
}
