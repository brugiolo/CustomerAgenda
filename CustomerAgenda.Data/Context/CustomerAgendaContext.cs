using CustomerAgenda.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAgenda.Data.Context
{
    public partial class CustomerAgendaContext : DbContext
    {
        public CustomerAgendaContext() { }

        public CustomerAgendaContext(DbContextOptions<CustomerAgendaContext> options) : base(options) { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<PhoneContact> PhoneContacts { get; set; }
        public virtual DbSet<Hostel> Hostels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
