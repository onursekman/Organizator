namespace OrganizatorENTİTY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            Comment_Organizasyon = new HashSet<Comment_Organizasyon>();
        }

        public int ID { get; set; }

        [Required]
        public string Comment_detail { get; set; }

        public int PeopleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Organizasyon> Comment_Organizasyon { get; set; }

        public virtual People People { get; set; }
    }
}
