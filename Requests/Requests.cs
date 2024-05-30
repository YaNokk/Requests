namespace Requests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requests()
        {
            Comments = new HashSet<Comments>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int requestID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate { get; set; }

        [StringLength(50)]
        public string homeTechType { get; set; }

        [StringLength(100)]
        public string homeTechModel { get; set; }

        [StringLength(255)]
        public string problemDescription { get; set; }

        public int Status_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? completionDate { get; set; }

        [StringLength(255)]
        public string repairParts { get; set; }

        public int masterID { get; set; }

        public int clientID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        public virtual Status Status { get; set; }
    }
}
