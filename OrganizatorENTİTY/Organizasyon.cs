namespace OrganizatorENTİTY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizasyon")]
    public partial class Organizasyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizasyon()
        {
            Comment_Organizasyon = new HashSet<Comment_Organizasyon>();
            People_Organizayson = new HashSet<People_Organizayson>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string OrganizasyonName { get; set; }

        public int CategoriesID { get; set; }

        public int PeopleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Time { get; set; }

        public int Number_of_Participants { get; set; }

        [Required]
        public string Picture { get; set; }

        [Column(TypeName = "date")]
        public DateTime Application_date { get; set; }

        public virtual Categories Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Organizasyon> Comment_Organizasyon { get; set; }

        public virtual People People { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People_Organizayson> People_Organizayson { get; set; }
    }
}
