namespace HSM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPOINTMENT")]
    public partial class APPOINTMENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Appointment_id { get; set; }

        public int? ID_Patient { get; set; }

        public int? ID_Dep { get; set; }

        [Column(TypeName = "date")]
        public DateTime? app_date { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        public virtual PATIENT PATIENT { get; set; }
    }
}
