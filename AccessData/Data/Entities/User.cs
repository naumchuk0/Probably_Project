using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Data.Entities
{
    public class User : IdentityUser
    {
        public DateTime Birthday { get; set; }
    }
}
