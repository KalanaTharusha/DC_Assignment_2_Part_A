using Microsoft.EntityFrameworkCore;
using Bank_Data_DLL;

namespace Bank_Data_Web_Service.Data
{
    public class DBManager : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Bank.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>();

            User user = new User();
            user.Id = 1;
            user.Name = "user1";
            user.Email = "user1@email.com";
            user.Address = "user1 address";
            user.Phone = 0710000001;
            user.Picture = "user1 picture url";
            user.Password = "user1pass";
            users.Add(user);

            user = new User();
            user.Id = 2;
            user.Name = "user2";
            user.Email = "user2@email.com";
            user.Address = "user2 address";
            user.Phone = 0710000002;
            user.Picture = "user2 picture url";
            user.Password = "user2pass";
            users.Add(user);

            user = new User();
            user.Id = 3;
            user.Name = "user3";
            user.Email = "user3@email.com";
            user.Address = "user3 address";
            user.Phone = 0710000003;
            user.Picture = "user3 picture url";
            user.Password = "user3pass";
            users.Add(user);

            //Account account = new Account();
            //account.Id = 4;
            //account.AccountNo = 21;
            //account.Balance = 6567557;
            //account.HolderId = 1;

            modelBuilder.Entity<User>().
                HasMany(a => a.Accounts)
                .WithOne(u => u.Holder)
                .HasForeignKey(a => a.HolderId);

            modelBuilder.Entity<Account>().
                HasMany(t => t.Transactions)
                .WithOne(a => a.Account)
                .HasForeignKey(t => t.AccountId);

            modelBuilder.Entity<User>().HasData(users);
            //modelBuilder.Entity<Account>().HasData(account);

        }

        public DbSet<Bank_Data_DLL.User>? User { get; set; }

        public DbSet<Bank_Data_DLL.Account>? Account { get; set; }

        public DbSet<Bank_Data_DLL.Transaction>? Transaction { get; set; }
    }
}
