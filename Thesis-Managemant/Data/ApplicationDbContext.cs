﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using Thesis_Managemant.Models;

namespace Thesis_Managemant.Data
{
    public class ApplicationDbContext
        : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
