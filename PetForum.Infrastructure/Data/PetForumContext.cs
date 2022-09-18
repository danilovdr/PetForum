using Microsoft.EntityFrameworkCore;
using PetForum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetForum.Infrastructure.Data
{
    public class PetForumContext : DbContext
    {
        public PetForumContext(DbContextOptions<PetForumContext> options) : base(options) {}
        public DbSet <SubForum> SubForums { get; set; }

    }
}
