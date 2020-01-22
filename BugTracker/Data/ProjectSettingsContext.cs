using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BugTracker.Data
{
    public class ProjectSettingsContext : DbContext
    {
        public ProjectSettingsContext(DbContextOptions<ProjectSettingsContext> options) : base(options)
        {
        }

        public DbSet<ProjectSettingsModel> ProjectSettings { get; set; }
        public DbSet<ProjectMembersModel> Project_Members { get; }
        public DbSet<Bugs> Bugs { get; }
        public DbSet<Task> Task { get; }


    }
}
