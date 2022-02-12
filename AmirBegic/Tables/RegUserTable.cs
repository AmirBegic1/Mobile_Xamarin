using System;
using System.Collections.Generic;
using System.Text;

namespace AmirBegic.Tables
{
    class RegUserTable
    {
        public Guid userId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPasswword { get; set; }

    }
}
