using System;
using System.Collections.Generic;
using System.Text;

namespace Student.NotificationPattern.ValueObjects
{
    public class Email
    {
        public string email { get; private set; }

        public Email(string email)
        {
            this.email = email;
        }
    }
}
