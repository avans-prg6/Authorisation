using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorisation.ViewModels
{
    public class RegisterForm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string PasswordRepeat { get; set; }
    }
}
