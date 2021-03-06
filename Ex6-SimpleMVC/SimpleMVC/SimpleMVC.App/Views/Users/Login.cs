﻿using SimpleMVC.App.MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.Views.Users
{
    public class Login : IRenderable
    {
        public string Render()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<h3>Login</h3>");
            sb.AppendLine("<form action=\"login\" method=\"POST\"><br/>");
            sb.AppendLine("Username: <input type=\"tex\" name=\"Username\"/><br/>");
            sb.AppendLine("Password: <input type=\"password\" name=\"Password\"/><br/>");
            sb.AppendLine("<input type=\"submit\" value=\"Register\"/>");
            sb.AppendLine("</form><br/>");

            return sb.ToString();
        }
    }
}
