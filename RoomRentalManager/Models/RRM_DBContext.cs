using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace RoomRentalManager.Models
{
    public partial class RRM_DBContext : DbContext
    {
        public RRM_DBContext()
        {
        }

        public RRM_DBContext(DbContextOptions<RRM_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Apartment> Apartment { get; set; }
        public virtual DbSet<ApartmentInfo> ApartmentInfo { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<ReceiversMessages> ReceiversMessages { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UsersNotifications> UsersNotifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Data source = RRM_DB.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasIndex(e => e.RoomId)
                    .HasName("Advertisement_Room_id_key")
                    .IsUnique();

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Room)
                    .WithOne(p => p.Advertisement)
                    .HasForeignKey<Advertisement>(d => d.RoomId)
                    .HasConstraintName("Advertisement_fk0");
            });

            modelBuilder.Entity<Apartment>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.Property(e => e.YearOfRenovation).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Apartment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Apartment_fk0");
            });

            modelBuilder.Entity<ApartmentInfo>(entity =>
            {
                entity.Property(e => e.ApartmentId).HasColumnName("Apartment_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Apartment)
                    .WithMany(p => p.ApartmentInfo)
                    .HasForeignKey(d => d.ApartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ApartmentInfo_fk0");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_id");

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.Property(e => e.Source).IsRequired();

                entity.Property(e => e.TenantId).HasColumnName("Tenant_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.DocumentOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Document_fk0");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("Document_fk2");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DocumentTenant)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Document_fk1");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.AdvertisementId).HasColumnName("Advertisement_id");

                entity.Property(e => e.Source).IsRequired();

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.AdvertisementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Image_fk0");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Message_fk0");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("Payment_fk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Payment_fk0");
            });

            modelBuilder.Entity<ReceiversMessages>(entity =>
            {
                entity.ToTable("Receivers_Messages");

                entity.Property(e => e.MessageId).HasColumnName("Message_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.ReceiversMessages)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Receivers_Messages_fk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceiversMessages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Receivers_Messages_fk0");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.AdvertisementId).HasColumnName("Advertisement_id");

                entity.Property(e => e.SendDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.AdvertisementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Request_fk0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Request_fk1");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.ApartmentId).HasColumnName("Apartment_id");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MoveInDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Apartment)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.ApartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Room_fk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Room_fk0");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PersonalDocumentNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(64);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UsersNotifications>(entity =>
            {
                entity.ToTable("Users_Notifications");

                entity.Property(e => e.NotificationId).HasColumnName("Notification_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.UsersNotifications)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_Notifications_fk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_Notifications_fk0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
