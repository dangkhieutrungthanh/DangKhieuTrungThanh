namespace DangKhieuTrungThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [Key]
        public int MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }
    }
}
