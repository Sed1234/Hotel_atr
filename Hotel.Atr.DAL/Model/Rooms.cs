namespace Hotel.Atr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rooms()
        {
            RoomOptions = new HashSet<RoomOptions>();
        }

        [Key]
        public int RoomId { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string PathBasePicture { get; set; }

        public int RoomTypeId { get; set; }

        public int Floor { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomOptions> RoomOptions { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
