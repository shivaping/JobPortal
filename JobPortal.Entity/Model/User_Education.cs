namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Education_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialization { get; set; }

        [Required]
        [StringLength(50)]
        public string Institute { get; set; }

        public int Year { get; set; }

        public virtual User User { get; set; }
    }
}
