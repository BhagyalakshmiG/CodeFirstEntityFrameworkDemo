using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Bed
    {
        public int Id { get; set; }
        public int BedNo { get; set; }
        public int Rent { get; set; }
    }

    public class IDProofMaster
    {
        public int Id { get; set; }
        public string ProofName { get; set; }
    }

    public class PG
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
    }

    public class RoleMaster
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }

    public class Room
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        [ForeignKey("RoleMaster")]
        public int RoleMaster_Id { get; set; }
        public int PG_Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public bool FoodOption { get; set; }
        public int IDProofMaster_Id { get; set; }
        public int Room_Id { get; set; }

        public virtual RoleMaster RoleMaster { get; set; }
    }

    public class UserContext : DbContext
    {
        public UserContext()
        {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoleMaster> RoleMaster { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<IDProofMaster> IdProofMaster { get; set; }
        public DbSet<PG> PGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(s => new { s.Email, s.MobileNo });
        }
    }

    public class MyInitializer : DropCreateDatabaseAlways<UserContext>
    {

    }
}
