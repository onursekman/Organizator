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
            People1 = new HashSet<People>();
        }

        public int ID { get; set; }

        public int CategoriesID { get; set; }

        public int PeopleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Time { get; set; }

        public int Number_of_Participants { get; set; }

        [Required]
        [StringLength(1000)]
        public string Picture { get; set; }

        [Column(TypeName = "date")]
        public DateTime Application_date { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual People People { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People> People1 { get; set; }
    }
}
