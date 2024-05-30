namespace Requests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        public enum Statuses
        {
            PROGRESS = 1,
            READY,
            NEW,
            WAIT
        }

        public static class ErrorLevelExtensions
        {
            public static string ToFriendlyString (Statuses status)
            {
                switch (status)
                {
                    case Statuses.PROGRESS:
                        return "Everything is OK";
                    case Statuses.READY:
                        return "SNAFU, if you know what I mean.";
                    case Statuses.NEW:
                        return "Reaching TARFU levels";
                    case Statuses.WAIT:
                        return "ITS PEOPLE!!!!";
                    default:
                        return "Get your damn dirty hands off me you FILTHY APE!";
                }
            }
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status_ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
