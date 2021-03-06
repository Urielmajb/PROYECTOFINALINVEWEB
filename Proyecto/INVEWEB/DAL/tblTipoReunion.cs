namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTipoReunion")]
    public partial class tblTipoReunion
    {
        [Key]
        public int ID_Tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoReunion { get; set; }
    }
}
