using System;
using System.Collections.Generic;
using System.Text;

namespace VideoConverter.AuthLibrary
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockedoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
    }
}
