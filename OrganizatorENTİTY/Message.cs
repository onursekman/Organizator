namespace OrganizatorENTİTY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ReceiverID { get; set; }

        public int SenderID { get; set; }

        [Required]
        public string Message_Detail { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }
    }
}
