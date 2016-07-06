namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employer_Posting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employer_Posting()
        {
            User_Jobs = new HashSet<User_Jobs>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Employer_Posting_Id { get; set; }

        public int User_Id { get; set; }

        public int Employer_Posting_Type_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Contact_Person { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [StringLength(50)]
        public string Jobcode { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public int State_Id { get; set; }

        public int Country_Id { get; set; }

        public int Education_Levelid { get; set; }

        public int Job_Type_Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Min_Salary { get; set; }

        [Column(TypeName = "money")]
        public decimal? Max_Salary { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Job_Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Posting_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Posted_By { get; set; }

        public virtual Employer_Posting_Type Employer_Posting_Type { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Jobs> User_Jobs { get; set; }
    }
}
