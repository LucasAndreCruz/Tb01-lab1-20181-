﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppTb01Lab1_LALC.Models
{
    public class AutomovelContext : DbContext
    {
        public AutomovelContext (DbContextOptions<AutomovelContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTb01Lab1_LALC.Models.Automovel> Automovel { get; set; }
    }
}
