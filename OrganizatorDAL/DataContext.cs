namespace OrganizatorENTİTY
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Organizasyon> Organizasyon { get; set; }
        public virtual DbSet<People> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.CategoriesName)
                .IsFixedLength();

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Organizasyon)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organizasyon>()
                .Property(e => e.Picture)
                .IsFixedLength();

            modelBuilder.Entity<Organizasyon>()
                .HasMany(e => e.People1)
                .WithMany(e => e.Organizasyon1)
                .Map(m => m.ToTable("People-Organizayson").MapLeftKey("OrganizasyonID").MapRightKey("PeopleID"));

            modelBuilder.Entity<People>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<People>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<People>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<People>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<People>()
                .HasMany(e => e.Message)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.ReceiverID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Message1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.SenderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Organizasyon)
                .WithRequired(e => e.People)
                .HasForeignKey(e => e.PeopleID)
                .WillCascadeOnDelete(false);
        }
    }
}
