namespace OrganizatorENTİTY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment_Organizasyon
    {
        public int ID { get; set; }

        public int ComentID { get; set; }

        public int OrganizasyonID { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual Organizasyon Organizasyon { get; set; }
    }
}
