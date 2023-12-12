namespace HSM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCTOR")]
    public partial class DOCTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Doc { get; set; }

        [StringLength(30)]
        public string DOC_Name { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        public int? ID_Dep { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }
    }
}
