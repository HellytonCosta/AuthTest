using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthTest.Areas.Identity.Data;

public class AuthTestUser : IdentityUser
{
    public string MID { get; set; }
    public bool KeepLoggedIn { get; set; }
}

