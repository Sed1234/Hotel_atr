namespace Hotel.Atr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomOptions
    {
        public int RoomOptionsId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? Room_RoomId { get; set; }

        public virtual Rooms Rooms { get; set; }
    }
}
