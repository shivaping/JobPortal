namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Detail_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        [MaxLength(255)]
        public byte[] Address1 { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public int State_Id { get; set; }

        public int Country_Id { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public int Phone { get; set; }

        public int? Fax { get; set; }

        [Required]
        [MaxLength(100)]
        public byte[] Email { get; set; }

        [StringLength(100)]
        public string Secondary_Email { get; set; }

        [StringLength(255)]
        public string Website { get; set; }

        [Column(TypeName = "text")]
        public string Profile { get; set; }

        public bool? Married { get; set; }

        public DateTime Created_Date { get; set; }

        public DateTime Updated_Date { get; set; }

        public virtual User User { get; set; }
    }
}
