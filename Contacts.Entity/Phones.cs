namespace Contacts.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phones
    {
        [Key]
        public int PhoneID { get; set; }

        public int PersonID { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        public virtual Persons Persons { get; set; }
    }
}
