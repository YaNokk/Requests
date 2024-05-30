namespace Requests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int commentID { get; set; }

        [StringLength(255)]
        public string message { get; set; }

        public int masterID { get; set; }

        public int requestID { get; set; }

        public virtual Users Users { get; set; }

        public virtual Requests Requests { get; set; }
    }
}
