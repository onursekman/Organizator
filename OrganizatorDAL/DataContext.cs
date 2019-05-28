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
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Organizasyon> Organizasyon { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<People_Organizayson> People_Organizayson { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.CategoriesName)
                .IsFixedLength();

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Organizasyon)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.Organizasyon)
                .WithMany(e => e.Comment)
                .Map(m => m.ToTable("Comment_Organizasyon").MapLeftKey("ComentID").MapRightKey("OrganizasyonID"));

            modelBuilder.Entity<Organizasyon>()
                .Property(e => e.OrganizasyonName)
                .IsFixedLength();

            modelBuilder.Entity<Organizasyon>()
                .HasMany(e => e.People_Organizayson)
                .WithRequired(e => e.Organizasyon)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.Comment)
                .WithRequired(e => e.People)
                .WillCascadeOnDelete(false);

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
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.People_Organizayson)
                .WithRequired(e => e.People)
                .WillCascadeOnDelete(false);
        }
    }
}
