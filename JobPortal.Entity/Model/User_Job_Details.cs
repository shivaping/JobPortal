namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Job_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Job_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Resume_Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Resume_Description { get; set; }

        [Required]
        public byte[] Resume { get; set; }

        public int Current_Location { get; set; }

        [Required]
        [StringLength(255)]
        public string Preferred_Location { get; set; }

        [Required]
        [StringLength(255)]
        public string Current_Role { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Dob { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        public int Experience { get; set; }

        [Column(TypeName = "money")]
        public decimal Current_Ctc { get; set; }

        public bool Active { get; set; }

        public virtual User User { get; set; }
    }
}
