using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Model.Identity
{
    public class AppUser: IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
