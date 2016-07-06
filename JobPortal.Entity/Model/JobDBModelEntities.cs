namespace JobPortal.Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobDBModelEntities : DbContext
    {
        public JobDBModelEntities()
            : base("name=JobDBModelEntities")
        {
        }

        public virtual DbSet<Employer_Posting> Employer_Posting { get; set; }
        public virtual DbSet<Employer_Posting_Type> Employer_Posting_Type { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Detail> User_Detail { get; set; }
        public virtual DbSet<User_Education> User_Education { get; set; }
        public virtual DbSet<User_Job_Details> User_Job_Details { get; set; }
        public virtual DbSet<User_Jobs> User_Jobs { get; set; }
        public virtual DbSet<User_Skill> User_Skill { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Contact_Person)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Jobcode)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Min_Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Max_Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Job_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .Property(e => e.Posted_By)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting>()
                .HasMany(e => e.User_Jobs)
                .WithRequired(e => e.Employer_Posting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employer_Posting_Type>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting_Type>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employer_Posting_Type>()
                .HasMany(e => e.Employer_Posting)
                .WithRequired(e => e.Employer_Posting_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Skill_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Skill_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.User_Skill)
                .WithRequired(e => e.Skill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employer_Posting)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User_Education)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User_Job_Details)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User_Skill)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User_Detail)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Secondary_Email)
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<User_Detail>()
                .Property(e => e.Profile)
                .IsUnicode(false);

            modelBuilder.Entity<User_Education>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<User_Education>()
                .Property(e => e.Specialization)
                .IsUnicode(false);

            modelBuilder.Entity<User_Education>()
                .Property(e => e.Institute)
                .IsUnicode(false);

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Resume_Title)
                .IsUnicode(false);

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Resume_Description)
                .IsUnicode(false);

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Preferred_Location)
                .IsUnicode(false);

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Current_Role)
                .IsUnicode(false);

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<User_Job_Details>()
                .Property(e => e.Current_Ctc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<User_Type>()
                .Property(e => e.User_Type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User_Type>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.User_Type)
                .WillCascadeOnDelete(false);
        }
    }
}
