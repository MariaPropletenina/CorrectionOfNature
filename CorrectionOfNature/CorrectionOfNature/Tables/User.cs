﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionOfNature.Tables
{
    public class User
    {
        public Guid UserId { get; set; }
        //public string UserName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        //public string CurrentUser { get; set; }
    }
}
