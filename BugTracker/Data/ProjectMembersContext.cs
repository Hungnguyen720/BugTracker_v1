using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class ProjectMembersContext : DbContext
    {
        public ProjectMembersContext(DbContextOptions<ProjectMembersContext> options) : base(options)
        {
        }

        public DbSet<ProjectMembersModel> Project_Members { get; set; }
    }
}
