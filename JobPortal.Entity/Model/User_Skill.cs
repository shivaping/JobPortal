namespace JobPortal.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Skill_Id { get; set; }

        public int User_Id { get; set; }

        public int Skill_Id { get; set; }

        public virtual Skill Skill { get; set; }

        public virtual User User { get; set; }
    }
}
