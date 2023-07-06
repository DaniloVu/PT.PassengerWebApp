using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Web;
using System.Web.Services.Description;

namespace PT.PassengerWebApp.Data.DataAccess
{
    public class AppDbContext: DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
       


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AutoRotationUserDeviceRule>().HasKey(rule =>
            new { rule.UserID, rule.DeviceID });

            modelBuilder.Entity<TestProfileOptionMap>().HasKey(tpo =>
            new { tpo.TestProfileID, tpo.TestOptionID });

            modelBuilder.Entity<StaticTestProfileDeviceMap>().HasKey(tpo =>
          new { tpo.TestProfileID, tpo.DeviceID });

            modelBuilder.Entity<TestProfileDayOfTheWeekMap>().HasKey(tpd =>
          new { tpd.TestProfileID, tpd.DayOfTheWeekID });

            modelBuilder.Entity<UserRoleMap>().HasKey(urm =>
          new { urm.UserID, urm.RoleID });

            modelBuilder.Entity<UserModemMap>().HasKey(umm =>
          new { umm.UserID, umm.ModemID });
        }
    }
}