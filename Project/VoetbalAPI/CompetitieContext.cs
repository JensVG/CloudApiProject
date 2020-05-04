﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VoetbalAPI
{
    public class CompetitieContext: DbContext
    {
        public CompetitieContext(DbContextOptions<CompetitieContext> options): base(options)
        {

        }
        public DbSet<Model.Ploeg> Ploegen { get; set; }
        public DbSet<Model.Speler> Spelers { get; set; }
        public DbSet<Model.Beker> Bekers { get; set; }
    }
}
