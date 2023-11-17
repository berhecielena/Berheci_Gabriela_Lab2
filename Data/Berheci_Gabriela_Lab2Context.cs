﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Berheci_Gabriela_Lab2.Models;

namespace Berheci_Gabriela_Lab2.Data
{
    public class Berheci_Gabriela_Lab2Context : DbContext
    {
        public Berheci_Gabriela_Lab2Context (DbContextOptions<Berheci_Gabriela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Berheci_Gabriela_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Berheci_Gabriela_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Berheci_Gabriela_Lab2.Models.Author>? Author { get; set; }
    }
}
