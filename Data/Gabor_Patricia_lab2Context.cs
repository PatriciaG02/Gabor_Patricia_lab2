﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gabor_Patricia_lab2.Models;

namespace Gabor_Patricia_lab2.Data
{
    public class Gabor_Patricia_lab2Context : DbContext
    {
        public Gabor_Patricia_lab2Context (DbContextOptions<Gabor_Patricia_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gabor_Patricia_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Gabor_Patricia_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
