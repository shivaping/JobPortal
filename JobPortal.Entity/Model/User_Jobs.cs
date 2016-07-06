namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Jobs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Job_Id { get; set; }

        public int Employer_Posting_Id { get; set; }

        public DateTime Created_Date { get; set; }

        public virtual Employer_Posting Employer_Posting { get; set; }
    }
}
